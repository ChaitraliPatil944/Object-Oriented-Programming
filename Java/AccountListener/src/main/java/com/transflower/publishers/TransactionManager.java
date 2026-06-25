package com.transflower.publishers;

import com.transflower.publishers.operations.TransferFundOperation;

public class TransactionManager implements TransferFundOperation{
    @Override
    public void transfer(double amount, int fromAccount, int  toAccount) {
        // Implement the transfer logic here

        System.out.println("Transferring " + amount + " from " + fromAccount + " to " + toAccount);
       
    }
  

    
}
