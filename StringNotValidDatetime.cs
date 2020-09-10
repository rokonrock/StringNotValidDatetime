//SOLUTION #1:
//#############//
//In database, requestDate field type is datetime
//Make sure, requestDate is not null of empty (if that field in nullable in database)

//SOLUTION #2:
//ALTERNATE SOLUTION: in database, instead of making requestDate field nullable, you can set a default date - for example, GETDATE()

//Example of Solition #1: Approach #1:
//####################################
if (!String.IsNullOrEmpty(orderId) && (orderId != "0"))
{
	string query = "SELECT requestDate from serviceOrder WHERE requestDate is not null and id = " + QueryHandler.SqlString(orderId);
	var requestDateV = QueryHandler.GetField(query);
	if (requestDateV != null && requestDateV != "")
	{
		DateTime reqDate = Convert.ToDateTime(requestDateV);
		req.requestdate = reqDate;
	}
	else
	{
		req.requestdate = System.DateTime.Today;
	}
}
else if (((requestDate == null) || (requestDate == DateTime.MinValue)) && (String.IsNullOrEmpty(orderId) || (orderId == "0")))
{
	req.requestdate = System.DateTime.Today;
}
else
{
	req.requestdate = System.DateTime.Today;
}





