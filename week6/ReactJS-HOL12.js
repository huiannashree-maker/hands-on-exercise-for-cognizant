import React, { useState } from 'react';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  
  return (
    <div>
      {isLoggedIn ? (
        <div><h1>Welcome back</h1><button onClick={() => setIsLoggedIn(false)}>Logout</button></div>
      ) : (
        <div><h1>Please sign up.</h1><button onClick={() => setIsLoggedIn(true)}>Login</button></div>
      )}
    </div>
  );
}
export default App;