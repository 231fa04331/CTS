using SqlConnection con = new(cs);

con.Open();

SqlCommand cmd = new(
"INSERT INTO Employees VALUES(1,'John',50000)",
con);

cmd.ExecuteNonQuery();



string cs =
"Server=localhost;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";