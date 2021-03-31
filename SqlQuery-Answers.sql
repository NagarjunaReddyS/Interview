  
 
1.select * from  customer where name Like 'Joe%'
 
2.select p.name from product p 
 inner join OrderProduct op on p.ProductId = op.ProductId
 inner join Order O on o.OrderId = op.OrderId
 inner join Customer C On c.CustomerId = o.customerid where o.CreatedAt > '11/1/2016' ;

3.select p.name, sum(p.price) from product p 
  inner join OrderProduct op on p.ProductId = op.ProductId
  inner join Order O on o.OrderId = op.OrderId
  inner join Customer C On c.CustomerId = o.customerid  GROUP BY c.CustomerId ;


4.select c.name, count(o.OrderId) from product p 
  inner join OrderProduct op on p.ProductId = op.ProductId
  inner join Order O on o.OrderId = op.OrderId
  inner join Customer C On c.CustomerId = o.customerid  GROUP BY o.OrderId having count(p.ProductId) > 1 ;
 

 
 
 
  
  