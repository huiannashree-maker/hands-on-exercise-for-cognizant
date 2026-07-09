// Home.js
export default function Home() {
  return <h1>Welcome to the Home page of Student Management Portal</h1>;
}

// About.js
export default function About() {
  return <h1>Welcome to the About page of the Student Management Portal</h1>;
}

// Contact.js
export default function Contact() {
  return <h1>Welcome to the Contact page of the Student Management Portal</h1>;
}

// App.js (Call all three)
import Home from './Components/Home';
import About from './Components/About';
import Contact from './Components/Contact';

function App() {
  return (
    <div>
      <Home />
      <About />
      <Contact />
    </div>
  );
}