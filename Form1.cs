using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seed_Chip_Management_Studio
{





    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {

            }
        }
    }



    public class seedchip
    {
        static int idNext = 0;
        int id;

        Effect e1;
        Effect e2;
        Effect e3;
        Effect e4;
        Effect e5;
        Effect ec;


        public seedchip()
        {
            id = idNext;
            idNext++;
        }

        public seedchip(Effect ef1, Effect ef2, Effect ef3, Effect ef4, Effect ef5, Effect efc)
        {
            e1 = ef1;
            e2 = ef2;
            e3 = ef3;
            e4 = ef4;
            e5 = ef5;
            ec = efc;
        }







    }

    public enum Effect: uint
    {
        Damage                                  = 1,
        Kinetic                                 = 2,
        Thermal                                 = 3,
        EM                                      = 4,
        Spread                                  = 5,
        FireRate                                = 6,
        Destroyer                               = 7,
        Alien                                   = 8,
        Range                                   = 9,
        Heating                                 = 10,
        Cooling                                 = 11,
        Ellydium                                = 12,
        ReloadingModules                        = 13,
        CriticalChance                          = 14,
        CriticalDamage                          = 15,
        TargetLockTime                          = 16,
        ShieldResistanceKinetic                 = 17,
        ShieldResistanceThermal                 = 18,
        ShieldResistanceEM                      = 19,
        ShieldResistanceAll                     = 20,
        ShieldSize                              = 21,
        ShieldRegeneration                      = 22,
        ReloadingMissiles                       = 23,
        MissileMineDamage                       = 24,
        HullReduction                           = 25,
        ThreatenedLockOnVirus                   = 26,
        ThreatenedKineticRegeneration           = 27,
        ThreatenedThermalRegeneration           = 28,
        ThreatenedEMRegeneration                = 29,
        WeaponAugmentSkrahLauncher              = 30,
        WeaponAugmentClusterMissile             = 31,
        WeaponAugmentAimAssistedCannon          = 32,
        WeaponAugmentThilith                    = 33,
        WeaponAugmentStaticChain                = 34,
        WeaponAugmentDisintegrator              = 35,
        WeaponAugmentGauss                      = 36,
        HitResotresShield                       = 37,
        HitTransfersEnergy                      = 38,
        HitExplosion                            = 39,
        HitWeakensWeapon                        = 40,
        HitPushes                               = 41,
        ShieldPulsar                            = 42,
        ShieldHighCollisionImmunity             = 43,
        ShieldChancePurge                       = 44,
        ShieldHighResist                        = 45,
        ShieldLowDrainAoE                       = 46,
        ShieldDownExplosion                     = 47,
        ShieldDownRegeneration                  = 48,
        ShieldDownTransparency                  = 49,
        ShieldDownSuperSupport                  = 50,
        ShieldDownDiffusion                     = 51,
        ShieldDownStunAoE                       = 52,
        CritReduceShieldResist                  = 53,
        CritReduceHullResist                    = 54,
        CritChanceLockWeaponOrientation         = 55,
        CritChanceSlowTime                      = 56,
        CritChanceAmmoDetonation                = 57,
        CritChanceNegFXWipe                     = 58,
        CritChanceGravi                         = 59,
        KillAimbot                              = 60,
        KillWeaponSpreadReduction               = 61,
        KillWeaponFireRate                      = 63,
        KillDropBigSpeedBuff                    = 64,
        KillDropBigHullBuff                     = 65,
        KillDropBigShieldBuff                   = 66,
        KillRamDamage                           = 67,
        CloseDeathDamageBuff                    = 68,
        CloseDeathRadiation                     = 69,
        CloseDeathHullShield                    = 70,
        CloseDeathAcceleration                  = 71,
        SlowShieldResist                        = 72,
        FastTurtleShield                        = 73
    }


}
