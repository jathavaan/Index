import ReactDOM from "react-dom/client";
import App from "./App.tsx";
import { createTheme, ThemeProvider } from "@mui/material";
import "@fontsource/roboto/300.css";
import "@fontsource/roboto/400.css";
import "@fontsource/roboto/500.css";
import "@fontsource/roboto/700.css";
import "./index.css";

let theme = createTheme({
  components: {
    MuiContainer: {
      styleOverrides: {
        root: {
          padding: "0",
          maxWidth: "1192px",
        },
      },
    },
    MuiTypography: {
      styleOverrides: {
        h4: {
          fontWeight: 100,
        },
      },
    },
    MuiAppBar: {
      styleOverrides: {
        root: {
          backgroundColor: "#454f55",
          paddingTop: "16px",
          boxShadow: "none",
        },
      },
    },
    MuiInput: {
      styleOverrides: {
        root: {
          color: "#fff",
          borderRadius: "4px",
          outline: "none",
          border: "none",
          padding: "4px",
          "&:hover": {
            border: "none",
            outline: "none",
          },
        },
        input: {
          "&::placeholder": {
            color: "#fff",
            opacity: 1,
          },
        },
        underline: {
          "&:before": {
            borderBottom: "1px solid #fff",
          },
          "&:after": {
            borderBottom: "1px solid #fb9c25",
          },
          "&:hover:not(.Mui-disabled):before": {
            borderBottom: "1px solid #fb9c25",
          },
        },
      },
    },
    MuiButton: {
      styleOverrides: {
        root: {
          color: "#fff",
          textTransform: "none",
          padding: "8px 16px",
          "&:hover": {
            backgroundColor: "rgba(255, 255, 255, 0.1)",
          },
        },
      },
    },
  },
});

ReactDOM.createRoot(document.getElementById("root")!).render(
  <ThemeProvider theme={theme}>
    <App />
  </ThemeProvider>,
);
