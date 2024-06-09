import { Button, Typography } from "@mui/material";

interface NavigationBarButtonProps {
  buttonText: string;
}

export default function NavigationBarButton(props: NavigationBarButtonProps) {
  return (
    <Button
      variant={"text"}
      sx={{
        backgroundColor: "transparent",
        color: "white",
        paddingX: "8px",
        paddingBottom: "4px",
        textTransform: "none",
        borderRadius: "0px",
        borderBottom: "2px solid transparent",
        "&:hover": {
          backgroundColor: "transparent",
          color: "white",
          borderBottom: "2px solid white",
        },
      }}
    >
      <Typography className={"underline"}>{props.buttonText}</Typography>
    </Button>
  );
}
