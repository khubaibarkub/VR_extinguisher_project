using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Security.Cryptography;
using System.Text;

public class testhashing : MonoBehaviour
{

    void Start()
    {
        string inputString = "welcome to world";

        // Convert the input string to a byte array
        byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);

        // Create an instance of SHA-256 hash algorithm
        using (SHA256 sha256 = SHA256.Create())
        {
            // Compute the hash value from the input bytes
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            // Convert the hash bytes to a hexadecimal string
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

            // Print the resulting hash
            Debug.Log("Hashed String: " + hashString);
        }
    }

}
