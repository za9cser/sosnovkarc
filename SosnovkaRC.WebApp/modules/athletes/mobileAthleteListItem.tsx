import { faUser } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { AthleteModel } from "../../models/athletes/athlete";

type Props = {
    athlete: AthleteModel;
};

const MobileAthleteListItem = ({ athlete }: Props) => {
    return (
        <div className="py-1 border-bottom hstack gap-3">
            <FontAwesomeIcon icon={faUser} size="2x" />
            <span>
                {athlete.firstName}&nbsp;{athlete.lastName}
            </span>
        </div>
    );
};

export default MobileAthleteListItem;
