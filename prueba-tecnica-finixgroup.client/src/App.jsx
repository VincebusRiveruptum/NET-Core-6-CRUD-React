import Landing from './components/screens/Landing';
import { Helmet } from "react-helmet";


function App() {
    return (
        <div className="App">
          <header className="App-header">
            <Helmet>
              <link rel="preconnect" href="https://fonts.googleapis.com" />
              <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
              <link href="https://fonts.googleapis.com/css2?family=Khula:wght@400;600;800&display=swap" rel="stylesheet" />
            </Helmet>
            <Landing/>
          </header>
        </div>
      );
}

export default App;