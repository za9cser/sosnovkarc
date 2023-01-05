import { AthleteModel, AthletesModel } from "../models/athletes/athlete";
import { Response } from "../utils/axiosUtils/axiosActions";
import apiService from "../utils/axiosUtils/apiService";

const GET_ATHLETES = "athletes/";

const getAthletes = async () => await apiService.get<AthletesModel>(GET_ATHLETES);
const getAthlete = async (id: number) => await apiService.get<AthleteModel>(`${GET_ATHLETES}${id}`);

interface AthleteService {
    getAthletes: () => Promise<Response<AthletesModel>>;
    getAthlete: (id: number) => Promise<Response<AthleteModel>>;
}

const athleteService: AthleteService = { getAthletes, getAthlete };

export default athleteService;
