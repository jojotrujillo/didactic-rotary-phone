import { useEffect, useState } from "react";
import reactLogo from "./assets/react.svg";
import "./App.css";

function App() {
  const [count, setCount] = useState(0);
  const [weather, setWeather] = useState([]);
  const [index, setIndex] = useState(0);

  useEffect(() => {
    getWeather();
  }, []); // eslint-disable-line react-hooks/exhaustive-deps

  async function getWeather() {
    const response = await fetch("https://localhost:7049/WeatherForecast");
    const data = await response.json();
    setWeather(data);
  }

  const incrementForecast = () => {
    if (index < weather.length - 1) {
      setIndex(index + 1);
    } else {
      setIndex(0);
    }
  };

  return (
    <div className="App">
      <div>
        <a href="https://vitejs.dev" target="_blank" rel="noreferrer">
          <img src="/vite.svg" className="logo" alt="Vite logo" />
        </a>
        <a href="https://reactjs.org" target="_blank" rel="noreferrer">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <button className="right-card" onClick={incrementForecast}>
          {!weather.length
            ? []
            : `weather for ${new Date(
                weather[index].date
              ).toLocaleDateString()} will be ${weather[
                index
              ].summary.toLowerCase()} and ${weather[index].temperatureC}°C/${
                weather[index].temperatureF
              }°F`}
        </button>
        <p>
          Edit <code>src/App.jsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </div>
  );
}

export default App;
