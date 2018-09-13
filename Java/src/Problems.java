import org.junit.*;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class Problems {
    //region
    private Solution yourSolution;

    @Before
    public void setUp() throws Exception {
        yourSolution = new Solution();
    }
    //endregion

    @Test
    public void DIPS_Fact_1() throws Exception {
        Assert.assertEquals(false, yourSolution.isLeapYear(2015));
        Succeeded(1);
    }

    @Test
    public void DIPS_Fact_2() throws Exception {
        Assert.assertEquals(true, yourSolution.isLeapYear(1996));
        Succeeded(2);
    }

    @Test
    public void DIPS_Fact_3() throws Exception {
        Assert.assertEquals(false, yourSolution.isLeapYear(2100));
        Succeeded(3);
    }

    @Test
    public void DIPS_Fact_4() throws Exception {
        Assert.assertEquals(true, yourSolution.isLeapYear(2000));
        Succeeded(4);
    }

    @Test
    public void DIPS_Fact_5() throws Exception {
        Assert.assertEquals(false, yourSolution.isLeapYear(1997));
        Succeeded(5);
    }

    //region
    private static int[] results;

    @BeforeClass
    public static void setUpClass() throws Exception {
        results = new int[5];
    }

    @AfterClass
    public static void teardownClass() throws Exception {
        String resultString = "";
        for (int res :
                results) {
            resultString += res + ",";
        }
        resultString = resultString.substring(0, resultString.length() - 1);
        Path path = Paths.get("C:\\Users\\roh\\AppData\\Roaming\\DIPS Coding Competition\\results.txt");
        Files.write(path, resultString.getBytes());
    }

    private static void Succeeded(int n) {
        results[n - 1] = 1;
    }
    //endregion
}