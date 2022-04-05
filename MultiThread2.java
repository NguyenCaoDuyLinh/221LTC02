/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Admin
 */
public class MultiThread2 {

    public static void main(String[] args) {
        Thread thread = new Thread() {

            public void run() {
                try {
                    System.out.println("pause");
                    Thread.sleep(3000);
                    System.out.println("Restart");
                } catch (InterruptedException e) {
                }
            }
        };
        MyThread mythread = new MyThread();

        mythread.start();
    }
}

class MyThread extends Thread {

    public void run() {
        for (int i = 0; i < 10; i++) {
            try {
                System.out.println("Chao thay" + i);
                Thread.sleep(1);
                System.out.println("Hehe" + i);
            } catch (InterruptedException e) {
            }
        }
        System.out.println("");
    }
}
