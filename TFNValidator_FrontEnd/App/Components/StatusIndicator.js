import React from "react";
import StatusSuccess from "./StatusSuccess";
import StatusFailure from "./StatusFailure";

function StatusIndicator() {
    return (
        <>
            <StatusSuccess />
            <StatusFailure />
        </>
    );
}

export default StatusIndicator;