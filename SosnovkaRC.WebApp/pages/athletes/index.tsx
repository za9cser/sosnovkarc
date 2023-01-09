import { GetServerSideProps } from "next";
import athleteService from "../../crud/athletesCRUD";
import { AthletesModel } from "../../models/athletes/athlete";
import AthleteList from "../../modules/athletes/athleteList";

const Athletes = ({ athletes }: AthletesModel) => {
    return <>{athletes && <AthleteList athletes={athletes} />}</>;
};

export const getServerSideProps: GetServerSideProps = async (ctx) => {
    const result = await athleteService.getAthletes();

    return {
        props: {
            athletes: result.data,
        },
    };
};

export default Athletes;
