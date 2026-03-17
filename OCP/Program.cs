using OCP.Context;
using OCP.Concrete;

Console.WriteLine("");

var discountService = new DiscountService();

//The behavior changes on every call

// VIP
// We pass a VIP strategy without modifying DiscountService (OCP: extension)
var vipResult = discountService.CalculateDiscount(new VipDiscount(), 100m);
Console.WriteLine($"VIP Discount: {vipResult}");

// Regular
// We can switch to another strategy without changing existing code
var regularResult = discountService.CalculateDiscount(new RegularDiscount(), 100m);
Console.WriteLine($"Regular Discount: {regularResult}");

// Student
// New behavior added by creating a new class, no changes in DiscountService (OCP)
var studentResult = discountService.CalculateDiscount(new StudentDiscount(), 100m);
Console.WriteLine($"Student Discount: {studentResult}");