// Using map and arrow functions
const PlayerList = ({ players }) => (
  <ul>
    {players.map((item) => (
      <li key={item.name}>Mr. {item.name} <span>{item.score}</span></li>
    ))}
  </ul>
);

// Destructuring odd players [cite: 373]
export function OddPlayers([first, , third, , fifth]) {
  return (
    <div>
      <li>First: {first}</li>
      <li>Third: {third}</li>
      <li>Fifth: {fifth}</li>
    </div>
  );
}

// Merging arrays [cite: 374]
const T20Players = ['P1', 'P2', 'P3'];
const RanjiPlayers = ['P4', 'P5', 'P6'];
export const IndianPlayers = [...T20Players, ...RanjiPlayers];