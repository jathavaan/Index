import { Box, Container, Typography } from "@mui/material";
import NavigationBar from "./modules/navigation-bar/components/NavigationBar.tsx";

function App() {
  return (
    <Box>
      <NavigationBar />
      <Container sx={{ paddingTop: "128px" }}>
        <Typography variant={"h2"}>Hello, World!</Typography>
      </Container>
    </Box>
  );
}

export default App;
