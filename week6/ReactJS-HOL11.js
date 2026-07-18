import React, { useState } from 'react';

function EventApp() {
  const [count, setCount] = useState(5);
  const [amount, setAmount] = useState(0);

  const increment = () => { setCount(count + 1); alert("Hello Member1"); };
  const decrement = () => setCount(count - 1);
  const sayWelcome = (msg) => alert(msg);
  
  const handleConvert = () => {
    alert("Converting to Euro Amount is " + (amount * 80));
  };

  return (
    <div>
      <p>{count}</p>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>
      <button onClick={() => sayWelcome("welcome")}>Say welcome</button>
      <input type="number" onChange={(e) => setAmount(e.target.value)} />
      <button onClick={handleConvert}>Submit</button>
    </div>
  );
}
export default EventApp;