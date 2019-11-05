using System;
					
public class DiverseString {
	public static void Main() {
		Console.WriteLine(DiverseString(6, 1, 1));
	}
	
	public static string DiverseString(int aCount, int bCount, int cCount) {
		var diverseString = string.Empty;
		
		while (aCount > 0 || bCount > 0 || cCount > 0) {
			if (aCount >= 2) {
				diverseString += "aa";
				aCount -= 2;
			}
			else if (aCount == 1) {
				diverseString += 'a';
				aCount--;
			}
			
			if (bCount >= 2) {
				diverseString += "bb";
				bCount -= 2;
			}
			else if (bCount == 1) {
				diverseString += 'b';
				bCount--;
			}
			
			if (aCount > 0 && !diverseString.EndsWith("a")) continue;
			
			if (cCount >= 2) {
				diverseString += "cc";
				cCount -= 2;
			}
			else if (cCount == 1) {
				diverseString += 'c';
				cCount--;
			}
			
			if ((aCount > 0 && !diverseString.EndsWith("b")) || (bCount > 0 && !diverseString.EndsWith("c"))) continue;
		}
		
		if (diverseString.Contains("aaa") || diverseString.Contains("bbb") || diverseString.Contains("ccc"))
			return string.Empty;
		
		return diverseString;
	}
}
