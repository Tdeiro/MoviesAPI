import { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";
import { Header, List } from "semantic-ui-react";

export type Movies = {
  title: string;
  id: string;
  description: string;
  userId: string;
};
function App() {
  const [movies, setMovies] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/movies").then((response) => {
      setMovies(response.data);
    });
  }, []);

  return (
    <div>
      {" "}
      <Header as="h2" icon="users" content="Movies" />
      <List>
        {movies.map((movie: Movies) => (
          <List.Item key={movie.id}>{movie.title}</List.Item>
        ))}
      </List>
    </div>
  );
}

export default App;
