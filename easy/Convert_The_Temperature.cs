/*You should convert Celsius into Kelvin and Fahrenheit and return it as an array ans = [kelvin, fahrenheit].*/

public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double[] ans = {celsius + 273.15, celsius * 1.80 + 32.00}; 
        return ans;
    }
}
