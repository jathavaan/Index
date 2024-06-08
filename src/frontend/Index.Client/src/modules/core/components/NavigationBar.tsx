import { AppBar, Grid, Toolbar, Typography } from "@mui/material";
export default function NavigationBar() {
  return (
    <AppBar sx={{}}>
      <Toolbar>
        <Grid container>
          <Grid item xs={3}>
            <Typography variant="h4">.index</Typography>
          </Grid>
          <Grid item xs={6}></Grid>
          <Grid item xs={3}></Grid>
        </Grid>
      </Toolbar>
    </AppBar>
  );
}
