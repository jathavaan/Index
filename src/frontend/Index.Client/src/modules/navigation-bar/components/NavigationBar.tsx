import { AppBar, Container, Grid, Toolbar } from "@mui/material";
import NavigationBarLogo from "./NavigationBarLogo.tsx";
import NavigationBarSearchField from "./NavigationBarSeachField.tsx";

export default function NavigationBar() {
  return (
    <AppBar>
      <Toolbar sx={{ minHeight: "128px" }}>
        <Container sx={{ display: "flex", justifyContent: "space-between" }}>
          <Grid container>
            <Grid item>
              <NavigationBarLogo />
            </Grid>
          </Grid>
          <Grid container flexDirection={"column"}>
            <Grid
              container
              sx={{
                display: "flex",
                justifyContent: "space-between",
              }}
            >
              <Grid item xs={5}></Grid>
              <Grid
                xs={7}
                container
                justifyContent={"flex-end"}
                paddingBottom={3}
              >
                <NavigationBarSearchField />
              </Grid>
            </Grid>
          </Grid>
        </Container>
      </Toolbar>
    </AppBar>
  );
}
