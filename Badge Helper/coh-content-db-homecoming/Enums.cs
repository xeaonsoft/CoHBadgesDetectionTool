using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Helper.coh_content_db_homecoming
{
    public enum BadgeType
    {
        ACCOLADE = 1,
        ACCOMPLISHMENT = 2,
        ACHIEVEMENT = 3,
        AE = 4,
        CONSIGNMENT = 5,
        DAY_JOB = 6,
        DEFEAT = 7,
        EVENT = 8,
        EXPLORATION = 9,
        GLADIATOR = 10,
        HISTORY = 11,
        INVENTION = 12,
        OUROBOROS = 13,
        PVP = 14,
        VETERAN = 15

    }
    public enum BadgePartialType
    {
        BADGE = 1,
        PLAQUE = 2,
        INVENTION_PLUS_ONE = 3,
        INVENTION = 4
    }
    public enum PlaqueType
    {
        MONUMENT = 1,
        WALL_PLAQUE = 2
    }
    public enum EnhancementCategory
    {
        DEFENSE_BUFF = 1,
        RESIST_DAMAGE = 2,
        INTANGIBILITY = 3,
        DAMAGE = 4,
        KNOCKBACK = 5,
        ENDURANCE_MODIFICATION = 6,
        ENDURANCE_REDUCTION = 7,
        SLEEP = 8,
        SLOW = 9,
        HOLD = 10,
        STUN = 11,
        IMMOBILIZE = 12,
        FEAR = 13,
        ACCURACY = 14,
        TO_HIT_BUFF = 15,
        DEFENSE_DEBUFF = 16,
        TO_HIT_DEBUFF = 17,
        TAUNT = 18,
        CONFUSE = 19,
        RECHARGE_REDUCTION = 20,
        INTERRUPT_DURATION = 21,
        HEALING = 22,

        RUN_SPEED = 23,
        JUMP = 24,
        FLY_SPEED = 25,
        RANGE = 26,

    }

    /*

*/
    public enum Alternate
    {

        MV = 10,//MV need to have lower value then M alone
        FV = 20,//FV need to have lower value then F alone
        MH = 30,//MH need to have lower value then M alone
        FH = 40,//FH need to have lower value then F alone
        MP = 50,//MP need to have lower value then M alone
        FP = 60,//FP need to have lower value then F alone
        M = 100,
        F = 200,
        H = 300,
        V = 400,
        P = 500,

    }
}
