using SqlConnection con = new(cs);

con.Open();

SqlCommand cmd = new(
"INSERT INTO Employees VALUES(1,'John',50000)",
con);

cmd.ExecuteNonQuery();




SqlCommand cmd =
new SqlCommand(
"SELECT * FROM Employees",
con);

SqlDataReader dr =
cmd.ExecuteReader();

while(dr.Read())
{
    Console.WriteLine(
        $"{dr["EmployeeId"]} " +
        $"{dr["EmployeeName"]}");
}



SqlCommand cmd =
new SqlCommand(
"UPDATE Employees SET Salary=60000 WHERE EmployeeId=1",
con);

cmd.ExecuteNonQuery();




SqlCommand cmd =
new SqlCommand(
"DELETE FROM Employees WHERE EmployeeId=1",
con);

cmd.ExecuteNonQuery();