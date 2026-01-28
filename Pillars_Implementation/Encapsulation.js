class BankAccount {
  #balance = 0;   // private field

  deposit(amount) {
    if (amount > 0) {
      this.#balance += amount;
    }
  }

  getBalance() {
    return this.#balance;
  }
}

const acc = new BankAccount();
acc.deposit(5000);
console.log(acc.getBalance()); // 5000
console.log(acc.#balance); // SyntaxError: Private field '#balance' must be declared in an enclosing class


//encapsulation ensures that the internal state of an object is hidden from the outside world
//in javascript we can achieve encapsulation by private, closure ,getters setters