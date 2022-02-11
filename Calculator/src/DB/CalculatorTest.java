package DB;

import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Stack;

public class CalculatorTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Connection conn = null;
		PreparedStatement pstm = null;
		ResultSet rs = null;

		try {
			String select = "SELECT EXP, RESULT, ID FROM CALCRECORD";

			conn = DBConnection.getConnection();
			pstm = conn.prepareStatement(select);
			rs = pstm.executeQuery();

			while (rs.next()) {
				// java.sql.Date calctime = rs.getDate("calctime");
				String exp = rs.getString("exp");
				String expResult = rs.getString("result");
				String expId = rs.getString("id");

				Calculator calc = new Calculator(exp);
				String checkNum = fmt(calc.getRst());

				// String result = exp + " " + expResult;
				// System.out.println(result + " " + checkNum);

				if (expResult.equals(checkNum)) {
					// System.out.println("Y");
					String update = "UPDATE CALCRECORD SET VERITIME = SYSDATE, VERIFY ='Y' WHERE ID = '" + expId
							+ "' AND (VERIFY IS NULL OR MODIFYTIME IS NOT NULL)";
					pstm = conn.prepareStatement(update);
					pstm.executeUpdate();

				} else {
					// System.out.println("N");
					String update = "UPDATE CALCRECORD SET VERITIME = SYSDATE, VERIFY ='N' WHERE ID = '" + expId
							+ "' AND (VERIFY IS NULL OR MODIFYTIME IS NOT NULL)";
					pstm = conn.prepareStatement(update);
					pstm.executeUpdate();
				}

			}
		} catch (SQLException e) {
			System.out.println(e.toString());
			e.printStackTrace();
		} finally {
			try {
				if (rs != null)
					rs.close();
				if (pstm != null)
					pstm.close();
				if (conn != null)
					conn.close();
			} catch (Exception e) {
				throw new RuntimeException(e.getMessage());
			}
		}
	}

	public static class Calculator {
		String mathExp;

		public Calculator(String _mathExp) {
			mathExp = _mathExp;
			if (mathExp == "")
				mathExp = "0";
		}

		public double getRst() {
			Stack<Double> st = new Stack<Double>();
			for (String s : infix_to_postfix((ReadSpliter()))) {
				if (s.equals("+") || s.equals("-") || s.equals("×") || s.equals("÷"))
					st.push(calc(s, st.pop(), st.pop()));
				else
					st.push(Double.parseDouble(s));
			}

			return st.pop();
		}

		int prec(String op) {
			switch (op) {
			case "(":
			case ")":
				return 0;
			case "+":
			case "-":
				return 1;
			case "×":
			case "÷":
				return 2;
			}
			return -1;
		}

		ArrayList<String> infix_to_postfix(ArrayList<String> str) {
			ArrayList<String> postfix = new ArrayList<String>();
			Stack<String> oper = new Stack<String>();

			String ch, top_op;

			for (String s : str) {
				ch = s;

				switch (ch) {
				case "+":
				case "-":
				case "×":
				case "÷":
					while (!oper.isEmpty() && (prec(ch) <= prec(oper.peek()))) {
						postfix.add(oper.pop());
					}
					oper.push(ch);
					break;
				case "(":
					oper.push(ch);
					break;
				case ")":
					top_op = oper.pop();

					while (!top_op.equals("(")) {
						postfix.add(top_op);
						top_op = oper.pop();
					}
					break;
				default:
					postfix.add(ch);
					break;
				}
			}
			while (!oper.isEmpty())
				postfix.add(oper.pop());

			return postfix;
		}

		ArrayList<String> ReadSpliter() {
			ArrayList<String> list_str = new ArrayList<String>();

			String temp = "";
			boolean isNum = false;
			for (char c : mathExp.toCharArray()) {
				if ((c >= '0' && c <= '9') || c == '.') {
					temp += c;
					isNum = true;
				} else if (temp == "" && c == '-') {
					temp = "-";
					isNum = true;
				} else {
					if (isNum)
						list_str.add(temp);
					list_str.add("" + c);
					isNum = false;
					temp = "";
				}
			}
			if (temp != "")
				list_str.add(temp);

			return list_str;
		}

		double calc(String oprtr, double a, double b) {
			// 소수자리 계산시 오류를 피하기위해 BigDecimal사용
			BigDecimal c = new BigDecimal(String.valueOf(a));
			BigDecimal d = new BigDecimal(String.valueOf(b));

			BigDecimal result;

			switch (oprtr) {
			case "+":
				result = d.add(c);
				return result.doubleValue();
			case "-":
				result = d.subtract(c);
				return result.doubleValue();
			case "×":
				result = d.multiply(c);
				return result.doubleValue();
			case "÷":
				result = d.divide(c);
				return result.doubleValue();
			}
			return 0;
		}
	}

	public static String fmt(double d) {
		if (d == (long) d)
			return String.format("%d", (long) d);
		else
			return String.format("%s", d);
		// return Double.toString(d);
	}

}
