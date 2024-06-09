import { Input, IconButton, InputAdornment } from "@mui/material";
import SearchIcon from "@mui/icons-material/Search";

export default function NavigationBarSearchField() {
  return (
    <Input
      fullWidth={true}
      placeholder={"Search"}
      endAdornment={
        <InputAdornment position={"end"}>
          <IconButton onClick={() => {}} edge={"end"}>
            <SearchIcon sx={{ color: "#fff" }} />
          </IconButton>
        </InputAdornment>
      }
    />
  );
}
