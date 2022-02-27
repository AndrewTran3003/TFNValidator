import React, { useState } from "react";
import CircularProgress from "@mui/material/CircularProgress";

function ProgressIndicator() {
    const [display, setDisplay] = useState("none");
    const style = {
        display: display
    }
    return (
        < >
            <CircularProgress sx={style} />
        </>
    );
}
export default ProgressIndicator;