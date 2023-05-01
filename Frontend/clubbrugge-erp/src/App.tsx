import './App.css';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Matches from './components/matches.Overview.tsx';
import MatchDetails from './components/match.details.tsx';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Matches />} />
        <Route path="/match/:matchId" element={<MatchDetails />} />
      </Routes>
    </Router>
  );
}

export default App;


