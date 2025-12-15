// Problem Statement

// You are working as a Software Engineer at HCL Company. Your client has requested the design of a Smart Payment Gateway System for an application. The system should allow customers to perform transactions using different payment modes.

// The payment gateway must support multiple payment methods, and the selection of the payment method should be handled dynamically using a delegate in C#.

// Payment Modes Supported:

// Credit Card

// UPI

// Net Banking

// Requirements:

// Use a delegate to switch between different payment processing methods.

// Each payment method should process the transaction amount and confirm the payment.

// The system should be flexible enough to easily add new payment methods in the future.

// The objective is to design a clean and efficient payment mechanism that demonstrates the use of delegates for handling multiple transaction strategies.



using System;

delegate void Payment(double amount);

class PaymentGateway
{
    public static void CreditCard(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card");
    }

    public static void UPI(double amount)
    {
        Console.WriteLine("Paid " + amount + " using UPI");
    }

    public static void NetBanking(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Net Banking");
    }

    static void Main()
    {
        double amount = 2500;
        string mode = "UPI";

        Payment payment;

        if (mode == "CreditCard")
            payment = CreditCard;
        else if (mode == "UPI")
            payment = UPI;
        else
            payment = NetBanking;

        payment(amount);
    }
}
