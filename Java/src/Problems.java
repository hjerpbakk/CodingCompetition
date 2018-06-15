import org.junit.*;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class Problems {
    //region
    private Solution solution;

    @Before
    public void setUp() throws Exception {
        solution = new Solution();
    }
    //endregion

    @Test
    public void DIPS_Fact_1() throws Exception {
        int median  = solution.closestToZero("0,1,-1,3");

        Assert.assertEquals(0, median);
        Succeeded(1);
    }

    @Test
    public void DIPS_Fact_2() throws Exception {
        int median  = solution.closestToZero("45,90,1,1235,17,3,9");

        Assert.assertEquals(1, median);
        Succeeded(2);
    }

    @Test
    public void DIPS_Fact_3() throws Exception {
        int median  = solution.closestToZero("32,54,12,2,-2,64,42");

        Assert.assertEquals(-2, median);
        Succeeded(3);
    }

    @Test
    public void DIPS_Fact_4() throws Exception {
        int median  = solution.closestToZero("-5,-4,-3,-2,-1");

        Assert.assertEquals(-1, median);
        Succeeded(4);
    }

    @Test
    public void DIPS_Fact_5() throws Exception {
        int median  = solution.closestToZero("90,72,17,15,19");

        Assert.assertEquals(15, median);
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