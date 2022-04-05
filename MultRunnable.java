
import java.util.Set;
import java.net.*;
import java.io.*;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author Admin
 */
public class MultRunnable {

    public static void main(String[] args) {

        multiThread multiTM = new multiThread();
        Thread thread1 = new Thread(multiTM);
        Thread thread2 = new Thread(multiTM);
        thread1.setName("Network Programing");
        thread2.setName("Network Manage");
        thread1.start();
        thread2.start();
    }
}

class multiThread implements Runnable {

    @Override
    public void run() {
        try {
            for (int i = 0; i < 10; i++) {
                Thread.sleep(1000);
                System.out.println(Thread.currentThread().getName() + "");
            }
        } catch (Exception e) {

        }

    }
}
