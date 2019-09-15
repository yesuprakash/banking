declare @startDate datetime
declare @endDate datetime
set @startDate = '9/1/2011'
set @endDate = '9/30/2025'

select ac.Name, sum(py.Amount) as Usage, py.AccountId, ac.MonthlyCreditLimit from accounts ac 
join payments py on py.AccountId=ac.id where py.TransactionDate between @startDate and @endDate
group by ac.Name,py.AccountId, ac.MonthlyCreditLimit  
having sum(py.Amount) < ac.MonthlyCreditLimit  
order by Usage desc
