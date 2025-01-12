using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AuthService
{
    private bool _isLoggedIn = false;  // Default value
    public bool IsLoggedIn => _isLoggedIn;

    // Method to simulate login (for demo purposes)
    public void Login()
    {
        _isLoggedIn = true;
    }

    // Method to simulate logout
    public void Logout()
    {
        _isLoggedIn = false;
    }
}