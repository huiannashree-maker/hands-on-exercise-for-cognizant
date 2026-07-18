import React from 'react';
// Office space data[cite: 7]
const ItemName = { Name: "DBS", Rent: 50000, Address: 'Chennai' };
const sr = "path-to-image.jpg"; // Replace with actual image path

function App() {
  const color = ItemName.Rent <= 60000 ? 'textRed' : 'textGreen'; // Conditional styling[cite: 7]
  return (
    <div>
      <h1>Office Space, at Affordable Range</h1>
      <img src={sr} width="25%" height="25%" alt="Office Space" />
      <h1>Name: {ItemName.Name}</h1>
      <h3 className={color}>Rent: Rs. {ItemName.Rent}</h3>
      <h3>Address: {ItemName.Address}</h3>
    </div>
  );
}
export default App;