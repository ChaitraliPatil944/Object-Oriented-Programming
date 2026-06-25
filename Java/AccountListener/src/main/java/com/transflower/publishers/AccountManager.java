package com.transflower.publishers;
import java.util.*;

public class AccountManager {

    private Map <Integer, Account> accounts = new HashMap<>();

    public void addAccount(Account account) {
        accounts.put(account.getAccountNumber(), account);
    }

    public Account getAccount(int accountNumber) {
        return accounts.get(accountNumber);
    }


    
}
