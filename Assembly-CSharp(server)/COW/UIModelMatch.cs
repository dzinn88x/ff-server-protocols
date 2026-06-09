using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001F66 RID: 8038
	[Token(Token = "0x2001F66")]
	internal class UIModelMatch : UIBaseModel
	{
		// Token: 0x0600B11A RID: 45338 RVA: 0x00031B30 File Offset: 0x0002FD30
		[Token(Token = "0x600B11A")]
		[Address(RVA = "0x1510F1C", Offset = "0x1510F1C", VA = "0x7BBBD10F1C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x0600B11B RID: 45339 RVA: 0x00031B48 File Offset: 0x0002FD48
		[Token(Token = "0x17000BC9")]
		public int MatchTime
		{
			[Token(Token = "0x600B11B")]
			[Address(RVA = "0x1510F24", Offset = "0x1510F24", VA = "0x7BBBD10F24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600B11C RID: 45340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCA")]
		public MapConfigData MapConfig
		{
			[Token(Token = "0x600B11C")]
			[Address(RVA = "0x1510F2C", Offset = "0x1510F2C", VA = "0x7BBBD10F2C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600B11D RID: 45341 RVA: 0x00031B60 File Offset: 0x0002FD60
		[Token(Token = "0x17000BCB")]
		public bool IsEmulator
		{
			[Token(Token = "0x600B11D")]
			[Address(RVA = "0x1511020", Offset = "0x1511020", VA = "0x7BBBD11020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600B11E RID: 45342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCC")]
		public List<EPPlayerInfo> ElitePassRankingList
		{
			[Token(Token = "0x600B11E")]
			[Address(RVA = "0x1511028", Offset = "0x1511028", VA = "0x7BBBD11028")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600B11F RID: 45343 RVA: 0x00031B78 File Offset: 0x0002FD78
		// (set) Token: 0x0600B120 RID: 45344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BCD")]
		public bool IsChickenPlayerObserver
		{
			[Token(Token = "0x600B11F")]
			[Address(RVA = "0x1511030", Offset = "0x1511030", VA = "0x7BBBD11030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11468BC", Offset = "0x11468BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B120")]
			[Address(RVA = "0x1511038", Offset = "0x1511038", VA = "0x7BBBD11038")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11468CC", Offset = "0x11468CC")]
			set
			{
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600B121 RID: 45345 RVA: 0x00031B90 File Offset: 0x0002FD90
		// (set) Token: 0x0600B122 RID: 45346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BCE")]
		public bool IsCustomRoomSettingHideKillInfo
		{
			[Token(Token = "0x600B121")]
			[Address(RVA = "0x1511044", Offset = "0x1511044", VA = "0x7BBBD11044")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11468DC", Offset = "0x11468DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B122")]
			[Address(RVA = "0x151104C", Offset = "0x151104C", VA = "0x7BBBD1104C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11468EC", Offset = "0x11468EC")]
			set
			{
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600B123 RID: 45347 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		// (set) Token: 0x0600B124 RID: 45348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BCF")]
		public bool IsCustomRoomSettingNoSkill
		{
			[Token(Token = "0x600B123")]
			[Address(RVA = "0x1511058", Offset = "0x1511058", VA = "0x7BBBD11058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11468FC", Offset = "0x11468FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B124")]
			[Address(RVA = "0x1511060", Offset = "0x1511060", VA = "0x7BBBD11060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114690C", Offset = "0x114690C")]
			set
			{
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600B125 RID: 45349 RVA: 0x00031BC0 File Offset: 0x0002FDC0
		// (set) Token: 0x0600B126 RID: 45350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD0")]
		public bool IsCustomRoomSettingHideCloth
		{
			[Token(Token = "0x600B125")]
			[Address(RVA = "0x151106C", Offset = "0x151106C", VA = "0x7BBBD1106C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114691C", Offset = "0x114691C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B126")]
			[Address(RVA = "0x1511074", Offset = "0x1511074", VA = "0x7BBBD11074")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114692C", Offset = "0x114692C")]
			set
			{
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600B127 RID: 45351 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		// (set) Token: 0x0600B128 RID: 45352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD1")]
		public bool IsCustomRoomSettingUnlimitedAmmo
		{
			[Token(Token = "0x600B127")]
			[Address(RVA = "0x1511080", Offset = "0x1511080", VA = "0x7BBBD11080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114693C", Offset = "0x114693C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B128")]
			[Address(RVA = "0x1511088", Offset = "0x1511088", VA = "0x7BBBD11088")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114694C", Offset = "0x114694C")]
			set
			{
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x0600B129 RID: 45353 RVA: 0x00031BF0 File Offset: 0x0002FDF0
		// (set) Token: 0x0600B12A RID: 45354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD2")]
		public bool IsNoPowerGun
		{
			[Token(Token = "0x600B129")]
			[Address(RVA = "0x1511094", Offset = "0x1511094", VA = "0x7BBBD11094")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114695C", Offset = "0x114695C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B12A")]
			[Address(RVA = "0x151109C", Offset = "0x151109C", VA = "0x7BBBD1109C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114696C", Offset = "0x114696C")]
			set
			{
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x0600B12B RID: 45355 RVA: 0x00031C08 File Offset: 0x0002FE08
		// (set) Token: 0x0600B12C RID: 45356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD3")]
		public bool ShowingHallOverMask
		{
			[Token(Token = "0x600B12B")]
			[Address(RVA = "0x15110A8", Offset = "0x15110A8", VA = "0x7BBBD110A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114697C", Offset = "0x114697C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B12C")]
			[Address(RVA = "0x15110B0", Offset = "0x15110B0", VA = "0x7BBBD110B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114698C", Offset = "0x114698C")]
			set
			{
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600B12D RID: 45357 RVA: 0x00031C20 File Offset: 0x0002FE20
		// (set) Token: 0x0600B12E RID: 45358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD4")]
		public bool UserControlDirty
		{
			[Token(Token = "0x600B12D")]
			[Address(RVA = "0x15110BC", Offset = "0x15110BC", VA = "0x7BBBD110BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114699C", Offset = "0x114699C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B12E")]
			[Address(RVA = "0x15110C4", Offset = "0x15110C4", VA = "0x7BBBD110C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11469AC", Offset = "0x11469AC")]
			set
			{
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600B12F RID: 45359 RVA: 0x00031C38 File Offset: 0x0002FE38
		// (set) Token: 0x0600B130 RID: 45360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD5")]
		public bool EnableEPRecoveryOverwrite
		{
			[Token(Token = "0x600B12F")]
			[Address(RVA = "0x15110D0", Offset = "0x15110D0", VA = "0x7BBBD110D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11469BC", Offset = "0x11469BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B130")]
			[Address(RVA = "0x15110D8", Offset = "0x15110D8", VA = "0x7BBBD110D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11469CC", Offset = "0x11469CC")]
			set
			{
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600B131 RID: 45361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD6")]
		public List<TeammateStats> ArmsRaceAllPlayerStats
		{
			[Token(Token = "0x600B131")]
			[Address(RVA = "0x15110E4", Offset = "0x15110E4", VA = "0x7BBBD110E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600B132 RID: 45362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD7")]
		public List<{QAb\u0082~u> MLocalTeamPlayerIDs
		{
			[Token(Token = "0x600B132")]
			[Address(RVA = "0x15110EC", Offset = "0x15110EC", VA = "0x7BBBD110EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600B133 RID: 45363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD8")]
		public List<{QAb\u0082~u> MOppoTeamPlayerIDs
		{
			[Token(Token = "0x600B133")]
			[Address(RVA = "0x15110F4", Offset = "0x15110F4", VA = "0x7BBBD110F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600B134 RID: 45364 RVA: 0x00031C50 File Offset: 0x0002FE50
		// (set) Token: 0x0600B135 RID: 45365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD9")]
		public bool NeedShowExtraResultBG
		{
			[Token(Token = "0x600B134")]
			[Address(RVA = "0x15110FC", Offset = "0x15110FC", VA = "0x7BBBD110FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B135")]
			[Address(RVA = "0x1511104", Offset = "0x1511104", VA = "0x7BBBD11104")]
			set
			{
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600B136 RID: 45366 RVA: 0x00031C68 File Offset: 0x0002FE68
		// (set) Token: 0x0600B137 RID: 45367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDA")]
		public bool IsBlockQuickChat
		{
			[Token(Token = "0x600B136")]
			[Address(RVA = "0x1511110", Offset = "0x1511110", VA = "0x7BBBD11110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11469DC", Offset = "0x11469DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B137")]
			[Address(RVA = "0x1511118", Offset = "0x1511118", VA = "0x7BBBD11118")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11469EC", Offset = "0x11469EC")]
			set
			{
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600B138 RID: 45368 RVA: 0x00031C80 File Offset: 0x0002FE80
		// (set) Token: 0x0600B139 RID: 45369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDB")]
		public ulong LastMatchRecordUserID
		{
			[Token(Token = "0x600B138")]
			[Address(RVA = "0x1511124", Offset = "0x1511124", VA = "0x7BBBD11124")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600B139")]
			[Address(RVA = "0x151112C", Offset = "0x151112C", VA = "0x7BBBD1112C")]
			set
			{
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600B13A RID: 45370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B13B RID: 45371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDC")]
		public string LastMatchRecordUserName
		{
			[Token(Token = "0x600B13A")]
			[Address(RVA = "0x1511134", Offset = "0x1511134", VA = "0x7BBBD11134")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B13B")]
			[Address(RVA = "0x151113C", Offset = "0x151113C", VA = "0x7BBBD1113C")]
			set
			{
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600B13C RID: 45372 RVA: 0x00031C98 File Offset: 0x0002FE98
		[Token(Token = "0x17000BDD")]
		public bool HasLeaveGame
		{
			[Token(Token = "0x600B13C")]
			[Address(RVA = "0x1511144", Offset = "0x1511144", VA = "0x7BBBD11144")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B13D")]
		[Address(RVA = "0x151114C", Offset = "0x151114C", VA = "0x7BBBD1114C")]
		public void updateLeaveGame(bool flag)
		{
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B13E")]
		[Address(RVA = "0x1511158", Offset = "0x1511158", VA = "0x7BBBD11158")]
		public void UpdateMatchTime(int time)
		{
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B13F")]
		[Address(RVA = "0x1511200", Offset = "0x1511200", VA = "0x7BBBD11200")]
		public void StartMatch()
		{
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B140")]
		[Address(RVA = "0x151225C", Offset = "0x151225C", VA = "0x7BBBD1225C")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B141")]
		[Address(RVA = "0x15124D4", Offset = "0x15124D4", VA = "0x7BBBD124D4")]
		public void ClearEPRankingList()
		{
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600B142 RID: 45378 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		[Token(Token = "0x17000BDE")]
		public int LocalPlayerKillCount
		{
			[Token(Token = "0x600B142")]
			[Address(RVA = "0x1512534", Offset = "0x1512534", VA = "0x7BBBD12534")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600B143 RID: 45379 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		[Token(Token = "0x17000BDF")]
		public int LocalPlayerDeathCount
		{
			[Token(Token = "0x600B143")]
			[Address(RVA = "0x15127E0", Offset = "0x15127E0", VA = "0x7BBBD127E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600B144 RID: 45380 RVA: 0x00031CE0 File Offset: 0x0002FEE0
		[Token(Token = "0x17000BE0")]
		public int LocalPlayerAssistCount
		{
			[Token(Token = "0x600B144")]
			[Address(RVA = "0x1512A8C", Offset = "0x1512A8C", VA = "0x7BBBD12A8C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600B145 RID: 45381 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		[Token(Token = "0x17000BE1")]
		public float LocalPlayerKDA
		{
			[Token(Token = "0x600B145")]
			[Address(RVA = "0x1512CB0", Offset = "0x1512CB0", VA = "0x7BBBD12CB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600B146 RID: 45382 RVA: 0x00031D10 File Offset: 0x0002FF10
		[Token(Token = "0x17000BE2")]
		public int RemainingPlayerCountMax
		{
			[Token(Token = "0x600B146")]
			[Address(RVA = "0x1512D58", Offset = "0x1512D58", VA = "0x7BBBD12D58")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600B147 RID: 45383 RVA: 0x00031D28 File Offset: 0x0002FF28
		[Token(Token = "0x17000BE3")]
		public int RemainingPlayerCount
		{
			[Token(Token = "0x600B147")]
			[Address(RVA = "0x1512D60", Offset = "0x1512D60", VA = "0x7BBBD12D60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600B148 RID: 45384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE4")]
		public UIModelMatch.PlayerDeadInfo PlayerDeadInfoData
		{
			[Token(Token = "0x600B148")]
			[Address(RVA = "0x1512D68", Offset = "0x1512D68", VA = "0x7BBBD12D68")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600B149 RID: 45385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE5")]
		public UIModelMatch.PlayerDeadInfo LocalPlayerDeadInfoData
		{
			[Token(Token = "0x600B149")]
			[Address(RVA = "0x1512D70", Offset = "0x1512D70", VA = "0x7BBBD12D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600B14A RID: 45386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE6")]
		public MatchIncome LastMatchData
		{
			[Token(Token = "0x600B14A")]
			[Address(RVA = "0x1512D78", Offset = "0x1512D78", VA = "0x7BBBD12D78")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600B14B RID: 45387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE7")]
		public MatchStats LastMatchStats
		{
			[Token(Token = "0x600B14B")]
			[Address(RVA = "0x1512D80", Offset = "0x1512D80", VA = "0x7BBBD12D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x0600B14C RID: 45388 RVA: 0x00031D40 File Offset: 0x0002FF40
		// (set) Token: 0x0600B14D RID: 45389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE8")]
		public bool HasPendingMatchRequest
		{
			[Token(Token = "0x600B14C")]
			[Address(RVA = "0x1512D88", Offset = "0x1512D88", VA = "0x7BBBD12D88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B14D")]
			[Address(RVA = "0x1512D90", Offset = "0x1512D90", VA = "0x7BBBD12D90")]
			set
			{
			}
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B14E")]
		[Address(RVA = "0x1512F64", Offset = "0x1512F64", VA = "0x7BBBD12F64")]
		public void AddKnockDownInfo(string playerName, int weaponDataID, uint skinID, {QAb\u0082~u beKilledId, {QAb\u0082~u killerId, bool isHeadShot = false, uint knockDownPlayerRole = 0U)
		{
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B14F")]
		[Address(RVA = "0x15135BC", Offset = "0x15135BC", VA = "0x7BBBD135BC")]
		public void OnKnockOtherDown()
		{
		}

		// Token: 0x0600B150 RID: 45392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B150")]
		[Address(RVA = "0x1513620", Offset = "0x1513620", VA = "0x7BBBD13620")]
		public void AddBattleInfo(string battleInfo)
		{
		}

		// Token: 0x0600B151 RID: 45393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B151")]
		[Address(RVA = "0x15136EC", Offset = "0x15136EC", VA = "0x7BBBD136EC")]
		public void AddRedEnvelopeInfo(string battleInfo)
		{
		}

		// Token: 0x0600B152 RID: 45394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B152")]
		[Address(RVA = "0x15137B8", Offset = "0x15137B8", VA = "0x7BBBD137B8")]
		public void UpdateKillInfo({QAb\u0082~u killerID, int killCount)
		{
		}

		// Token: 0x0600B153 RID: 45395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B153")]
		[Address(RVA = "0x1513B68", Offset = "0x1513B68", VA = "0x7BBBD13B68")]
		public void UpdateLikeCountInfo({QAb\u0082~u playerID, uint likeCount)
		{
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B154")]
		[Address(RVA = "0x1513CA4", Offset = "0x1513CA4", VA = "0x7BBBD13CA4")]
		public void UpdateDeathInfo({QAb\u0082~u playerId, int deathCount)
		{
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B155")]
		[Address(RVA = "0x1514054", Offset = "0x1514054", VA = "0x7BBBD14054")]
		public void UpdateBombInfo(cEjo~wz infoType, params object[] param)
		{
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B156")]
		[Address(RVA = "0x15147F8", Offset = "0x15147F8", VA = "0x7BBBD147F8")]
		public void OnLandmineExplode(Player landmineOwner)
		{
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B157")]
		[Address(RVA = "0x1514A30", Offset = "0x1514A30", VA = "0x7BBBD14A30")]
		private void DispatchKillEvent(int weaponDataID)
		{
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B158")]
		[Address(RVA = "0x1514D90", Offset = "0x1514D90", VA = "0x7BBBD14D90")]
		public void OnKill({QAb\u0082~u killerID, {QAb\u0082~u beKilledID, int weaponDataID, uint hitbodyPart, uint skinId, bool isPendingRevive = false, int killStacks = 0, byte flags = 0, int killerScore = 0, int killerTeamScore = 0, int killerHypeLvl = 0, uint assis = 0U, uint hitRate = 0U, uint headShotRate = 0U, uint bekilledKillStack = 0U)
		{
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x00031D58 File Offset: 0x0002FF58
		[Token(Token = "0x600B159")]
		[Address(RVA = "0x1516E80", Offset = "0x1516E80", VA = "0x7BBBD16E80")]
		public bool NeedReplaceNameWithEllipsis(Player player)
		{
			return default(bool);
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B15A")]
		[Address(RVA = "0x1516824", Offset = "0x1516824", VA = "0x7BBBD16824")]
		public void OnKillByZombie({QAb\u0082~u killerID, {QAb\u0082~u beKilledID, int weaponDataID, uint hitbodyPart, uint skinId)
		{
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B15B")]
		[Address(RVA = "0x1513398", Offset = "0x1513398", VA = "0x7BBBD13398")]
		public string GetWeaponName(int weaponDataID)
		{
			return null;
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B15C")]
		[Address(RVA = "0x1516F88", Offset = "0x1516F88", VA = "0x7BBBD16F88")]
		public void OnPlayerQuit({QAb\u0082~u playerID)
		{
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B15D")]
		[Address(RVA = "0x1516DFC", Offset = "0x1516DFC", VA = "0x7BBBD16DFC")]
		public void OnAlivePlayerCountChanged(int remainingPlayers)
		{
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B15E")]
		[Address(RVA = "0x1517424", Offset = "0x1517424", VA = "0x7BBBD17424")]
		public void OnAddPlayer({QAb\u0082~u playerID, Player player)
		{
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B15F")]
		[Address(RVA = "0x1518218", Offset = "0x1518218", VA = "0x7BBBD18218")]
		private void SaveTeammateInfo(PlayerData playerData)
		{
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B160")]
		[Address(RVA = "0x1517F50", Offset = "0x1517F50", VA = "0x7BBBD17F50")]
		private PlayerData CreatePlayerData(Player player)
		{
			return null;
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B161")]
		[Address(RVA = "0x1518404", Offset = "0x1518404", VA = "0x7BBBD18404")]
		private PlayerData GetTeammateData({QAb\u0082~u pid)
		{
			return null;
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B162")]
		[Address(RVA = "0x15184FC", Offset = "0x15184FC", VA = "0x7BBBD184FC")]
		public void OnTeammateHeadScaleChange({QAb\u0082~u pid, float scale)
		{
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B163")]
		[Address(RVA = "0x15185D4", Offset = "0x15185D4", VA = "0x7BBBD185D4")]
		public void OnTeammateEpicClothesUpdate({QAb\u0082~u pid, uint oldClohtes, uint newClothes)
		{
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B164")]
		[Address(RVA = "0x15188B4", Offset = "0x15188B4", VA = "0x7BBBD188B4")]
		public void OnTeammateHeadAvatarChange({QAb\u0082~u pid, uint avatardataID)
		{
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B165")]
		[Address(RVA = "0x15188F8", Offset = "0x15188F8", VA = "0x7BBBD188F8")]
		private void RefreshEPRankingSurroundEffect()
		{
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B166")]
		[Address(RVA = "0x1518C90", Offset = "0x1518C90", VA = "0x7BBBD18C90")]
		public void UpdateEPRankingList(ulong userID, {QAb\u0082~u pID, bool isAI, object syncInfo)
		{
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B167")]
		[Address(RVA = "0x1519310", Offset = "0x1519310", VA = "0x7BBBD19310")]
		public void OnSwitchObserver({QAb\u0082~u trackingTargetID)
		{
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B168")]
		[Address(RVA = "0x15195FC", Offset = "0x15195FC", VA = "0x7BBBD195FC")]
		public void OnDelPlayer({QAb\u0082~u playerID)
		{
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B169")]
		[Address(RVA = "0x151982C", Offset = "0x151982C", VA = "0x7BBBD1982C")]
		public void OnRemoveTeam(byte teamID)
		{
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16A")]
		[Address(RVA = "0x1519830", Offset = "0x1519830", VA = "0x7BBBD19830")]
		public void SniperOn(bool v)
		{
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16B")]
		[Address(RVA = "0x1519920", Offset = "0x1519920", VA = "0x7BBBD19920")]
		public void RecordPlayerForDriftBottle()
		{
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16C")]
		[Address(RVA = "0x1519ED4", Offset = "0x1519ED4", VA = "0x7BBBD19ED4")]
		public void RequestStartMatchMaking(uint map_id, l}BQs\u0080\u0082 game_mode = l}BQs\u0080\u0082.EGAMEMODE_BattleRoyale, f match_mode = f.EMATCHMODE_CASUAL, uint map_difficulty = 0U, bool isRandomMap = false)
		{
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x00031D70 File Offset: 0x0002FF70
		[Token(Token = "0x600B16D")]
		[Address(RVA = "0x151A104", Offset = "0x151A104", VA = "0x7BBBD1A104")]
		private bool RequestStartMatchMakingInternal(uint map_id, l}BQs\u0080\u0082 game_mode = l}BQs\u0080\u0082.EGAMEMODE_BattleRoyale, f match_mode = f.EMATCHMODE_CASUAL, uint map_difficulty = 0U, bool isRandomMap = false)
		{
			return default(bool);
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16E")]
		[Address(RVA = "0x151ABA0", Offset = "0x151ABA0", VA = "0x7BBBD1ABA0")]
		public void RequestCancelMatchMaking()
		{
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B16F")]
		[Address(RVA = "0x151AC30", Offset = "0x151AC30", VA = "0x7BBBD1AC30")]
		public void RequestDropMatch()
		{
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B170")]
		[Address(RVA = "0x151ACC0", Offset = "0x151ACC0", VA = "0x7BBBD1ACC0")]
		public void RequestClearReconnectInfo()
		{
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B171")]
		[Address(RVA = "0x151AD50", Offset = "0x151AD50", VA = "0x7BBBD1AD50")]
		public void PendingMatchResult(MatchStatsRes data)
		{
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B172")]
		[Address(RVA = "0x151B198", Offset = "0x151B198", VA = "0x7BBBD1B198")]
		public void RequestMatchResultViaHTTP()
		{
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B173")]
		[Address(RVA = "0x151B3C0", Offset = "0x151B3C0", VA = "0x7BBBD1B3C0")]
		public void RequestMatchResultData()
		{
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x00031D88 File Offset: 0x0002FF88
		[Token(Token = "0x600B174")]
		[Address(RVA = "0x151B3C4", Offset = "0x151B3C4", VA = "0x7BBBD1B3C4")]
		public bool HasPendingReviveTeammates()
		{
			return default(bool);
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B175")]
		[Address(RVA = "0x151AD58", Offset = "0x151AD58", VA = "0x7BBBD1AD58")]
		private void CheckAndSendMatchResult()
		{
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x00031DA0 File Offset: 0x0002FFA0
		[Token(Token = "0x600B176")]
		[Address(RVA = "0x151B52C", Offset = "0x151B52C", VA = "0x7BBBD1B52C")]
		public bool IsMatchResultNotified()
		{
			return default(bool);
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B177")]
		[Address(RVA = "0x151B53C", Offset = "0x151B53C", VA = "0x7BBBD1B53C")]
		public void SetArmsRaceAllPlayerStats(MatchStats stats)
		{
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B178")]
		[Address(RVA = "0x151B698", Offset = "0x151B698", VA = "0x7BBBD1B698", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		[Token(Token = "0x600B179")]
		[Address(RVA = "0x151B718", Offset = "0x151B718", VA = "0x7BBBD1B718")]
		public bool CanUseQuickChat()
		{
			return default(bool);
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B17A")]
		[Address(RVA = "0x151B8AC", Offset = "0x151B8AC", VA = "0x7BBBD1B8AC")]
		public Player GetNearestEmoteLeader(uint emoteID, Vector3 pos)
		{
			return null;
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x00031DD0 File Offset: 0x0002FFD0
		[Token(Token = "0x600B17B")]
		[Address(RVA = "0x151BBC8", Offset = "0x151BBC8", VA = "0x7BBBD1BBC8")]
		public bool IsEmoteLeader({QAb\u0082~u pid)
		{
			return default(bool);
		}

		// Token: 0x0600B17C RID: 45436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B17C")]
		[Address(RVA = "0x151BC68", Offset = "0x151BC68", VA = "0x7BBBD1BC68")]
		public void SetEmoteLeader({QAb\u0082~u pid)
		{
		}

		// Token: 0x0600B17D RID: 45437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B17D")]
		[Address(RVA = "0x151BE64", Offset = "0x151BE64", VA = "0x7BBBD1BE64")]
		public void RemoveEmoteLeader({QAb\u0082~u pid)
		{
		}

		// Token: 0x0600B17E RID: 45438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B17E")]
		[Address(RVA = "0x151C094", Offset = "0x151C094", VA = "0x7BBBD1C094")]
		public void FollowEmoteLeader({QAb\u0082~u leaderPid)
		{
		}

		// Token: 0x0600B17F RID: 45439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B17F")]
		[Address(RVA = "0x151BDE8", Offset = "0x151BDE8", VA = "0x7BBBD1BDE8")]
		public void UnFollowEmoteLeader()
		{
		}

		// Token: 0x0600B180 RID: 45440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B180")]
		[Address(RVA = "0x151C18C", Offset = "0x151C18C", VA = "0x7BBBD1C18C")]
		public void UpdateFollowerEmote({QAb\u0082~u leaderPid, uint emoteID)
		{
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B181")]
		[Address(RVA = "0x151C34C", Offset = "0x151C34C", VA = "0x7BBBD1C34C")]
		public void GenerateMatchResult(Wb\u0080zYNb msg)
		{
		}

		// Token: 0x0600B182 RID: 45442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B182")]
		[Address(RVA = "0x151C81C", Offset = "0x151C81C", VA = "0x7BBBD1C81C")]
		public List<ResultTeamData> GenerateMatchResult()
		{
			return null;
		}

		// Token: 0x0600B183 RID: 45443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B183")]
		[Address(RVA = "0x151C824", Offset = "0x151C824", VA = "0x7BBBD1C824")]
		public List<PlayerData> GetPlayerDataListByTeamId(byte teamId)
		{
			return null;
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B184")]
		[Address(RVA = "0x151C8A4", Offset = "0x151C8A4", VA = "0x7BBBD1C8A4")]
		public PlayerData GetPlayerDataByAccountID(ulong accountID)
		{
			return null;
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B185")]
		[Address(RVA = "0x1513BAC", Offset = "0x1513BAC", VA = "0x7BBBD13BAC")]
		public PlayerData GetPlayerDataByPlayerID({QAb\u0082~u playerID)
		{
			return null;
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B186")]
		[Address(RVA = "0x151C978", Offset = "0x151C978", VA = "0x7BBBD1C978")]
		public void SetTeamScore(int idx, int score)
		{
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B187")]
		[Address(RVA = "0x151C998", Offset = "0x151C998", VA = "0x7BBBD1C998")]
		public void UpdateTeamScore(int score)
		{
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE9")]
		public HashSet<{QAb\u0082~u> LikedPlayerSet
		{
			[Token(Token = "0x600B188")]
			[Address(RVA = "0x151CAA8", Offset = "0x151CAA8", VA = "0x7BBBD1CAA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x0600B189 RID: 45449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEA")]
		public HashSet<{QAb\u0082~u> ReportedPlayerSet
		{
			[Token(Token = "0x600B189")]
			[Address(RVA = "0x151CAB0", Offset = "0x151CAB0", VA = "0x7BBBD1CAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B18A")]
		[Address(RVA = "0x151CAB8", Offset = "0x151CAB8", VA = "0x7BBBD1CAB8")]
		public void RequestLikePlayer({QAb\u0082~u id)
		{
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600B18B RID: 45451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEB")]
		public HashSet<{QAb\u0082~u> RequestedPlayerSet
		{
			[Token(Token = "0x600B18B")]
			[Address(RVA = "0x151CC08", Offset = "0x151CC08", VA = "0x7BBBD1CC08")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600B18C RID: 45452 RVA: 0x00031DE8 File Offset: 0x0002FFE8
		[Token(Token = "0x17000BEC")]
		public int PVERemainingEnemyCount
		{
			[Token(Token = "0x600B18C")]
			[Address(RVA = "0x151CC10", Offset = "0x151CC10", VA = "0x7BBBD1CC10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600B18D RID: 45453 RVA: 0x00031E00 File Offset: 0x00030000
		[Token(Token = "0x17000BED")]
		public int PVETurnCount
		{
			[Token(Token = "0x600B18D")]
			[Address(RVA = "0x151CC18", Offset = "0x151CC18", VA = "0x7BBBD1CC18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600B18E RID: 45454 RVA: 0x00031E18 File Offset: 0x00030018
		[Token(Token = "0x17000BEE")]
		public int PVEMaxTurnCount
		{
			[Token(Token = "0x600B18E")]
			[Address(RVA = "0x151CC20", Offset = "0x151CC20", VA = "0x7BBBD1CC20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600B18F RID: 45455 RVA: 0x00031E30 File Offset: 0x00030030
		[Token(Token = "0x17000BEF")]
		public int PVEEmemyKillCount
		{
			[Token(Token = "0x600B18F")]
			[Address(RVA = "0x151CC28", Offset = "0x151CC28", VA = "0x7BBBD1CC28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B190 RID: 45456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B190")]
		[Address(RVA = "0x151CC30", Offset = "0x151CC30", VA = "0x7BBBD1CC30")]
		public void UpdatePVERemainingEnemyCount(uint count)
		{
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B191")]
		[Address(RVA = "0x151CCA4", Offset = "0x151CCA4", VA = "0x7BBBD1CCA4")]
		public void UpdatePVETurnCount(int count)
		{
		}

		// Token: 0x0600B192 RID: 45458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B192")]
		[Address(RVA = "0x151CE04", Offset = "0x151CE04", VA = "0x7BBBD1CE04")]
		public void UpdatePVEMaxTurnCount(int count)
		{
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B193")]
		[Address(RVA = "0x151CF64", Offset = "0x151CF64", VA = "0x7BBBD1CF64")]
		public void UpdatePVEEmemyKillCount(int count)
		{
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x00031E48 File Offset: 0x00030048
		[Token(Token = "0x17000BF0")]
		public int MCSLocalTeamId
		{
			[Token(Token = "0x600B194")]
			[Address(RVA = "0x151CFD8", Offset = "0x151CFD8", VA = "0x7BBBD1CFD8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x0600B195 RID: 45461 RVA: 0x00031E60 File Offset: 0x00030060
		[Token(Token = "0x17000BF1")]
		public int CSTeamIdEyesOn
		{
			[Token(Token = "0x600B195")]
			[Address(RVA = "0x151CFE0", Offset = "0x151CFE0", VA = "0x7BBBD1CFE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B196 RID: 45462 RVA: 0x00031E78 File Offset: 0x00030078
		[Token(Token = "0x600B196")]
		[Address(RVA = "0x151CFE8", Offset = "0x151CFE8", VA = "0x7BBBD1CFE8")]
		public bool IsCSPlayerOnLeft({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x0600B197 RID: 45463 RVA: 0x00031E90 File Offset: 0x00030090
		[Token(Token = "0x600B197")]
		[Address(RVA = "0x151D088", Offset = "0x151D088", VA = "0x7BBBD1D088")]
		public bool IsCSTeamOnLeft(int teamId)
		{
			return default(bool);
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x0600B198 RID: 45464 RVA: 0x00031EA8 File Offset: 0x000300A8
		[Token(Token = "0x17000BF2")]
		public int CSWinTeamIdCurRound
		{
			[Token(Token = "0x600B198")]
			[Address(RVA = "0x151D098", Offset = "0x151D098", VA = "0x7BBBD1D098")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B199")]
		[Address(RVA = "0x151D0A0", Offset = "0x151D0A0", VA = "0x7BBBD1D0A0")]
		public void UpdateWinTeamIdCurRound(int teamId)
		{
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B19A")]
		[Address(RVA = "0x151D0A8", Offset = "0x151D0A8", VA = "0x7BBBD1D0A8")]
		public void UpdateLocalFactionID(int factionID)
		{
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600B19B RID: 45467 RVA: 0x00031EC0 File Offset: 0x000300C0
		[Token(Token = "0x17000BF3")]
		public int LocalODFaction
		{
			[Token(Token = "0x600B19B")]
			[Address(RVA = "0x151D0B0", Offset = "0x151D0B0", VA = "0x7BBBD1D0B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B19C")]
		[Address(RVA = "0x151D0B8", Offset = "0x151D0B8", VA = "0x7BBBD1D0B8")]
		public void UpdateLocalODFaction(int factionID)
		{
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B19D")]
		[Address(RVA = "0x151D1C8", Offset = "0x151D1C8", VA = "0x7BBBD1D1C8")]
		public void SetClanMatchResult(FakeSubmitRes tcpClanMatchResult)
		{
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B19E")]
		[Address(RVA = "0x151D1D0", Offset = "0x151D1D0", VA = "0x7BBBD1D1D0")]
		public FakeSubmitRes GetClanMatchResult()
		{
			return null;
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600B19F RID: 45471 RVA: 0x00031ED8 File Offset: 0x000300D8
		[Token(Token = "0x17000BF4")]
		public int LocalFactionID
		{
			[Token(Token = "0x600B19F")]
			[Address(RVA = "0x151D1D8", Offset = "0x151D1D8", VA = "0x7BBBD1D1D8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600B1A0 RID: 45472 RVA: 0x00031EF0 File Offset: 0x000300F0
		[Token(Token = "0x17000BF5")]
		public bool IsLocalFactionInLeft
		{
			[Token(Token = "0x600B1A0")]
			[Address(RVA = "0x151D1E0", Offset = "0x151D1E0", VA = "0x7BBBD1D1E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x00031F08 File Offset: 0x00030108
		[Token(Token = "0x600B1A1")]
		[Address(RVA = "0x151D1E8", Offset = "0x151D1E8", VA = "0x7BBBD1D1E8")]
		public bool IsFactionInLeft(int factionID)
		{
			return default(bool);
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x00031F20 File Offset: 0x00030120
		[Token(Token = "0x17000BF6")]
		public int LocalPlayerArmsLevel
		{
			[Token(Token = "0x600B1A2")]
			[Address(RVA = "0x151D2B4", Offset = "0x151D2B4", VA = "0x7BBBD1D2B4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1A3")]
		[Address(RVA = "0x151D2BC", Offset = "0x151D2BC", VA = "0x7BBBD1D2BC")]
		public void UpdateLocalPlayerArmsLevel(int level)
		{
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600B1A4 RID: 45476 RVA: 0x00031F38 File Offset: 0x00030138
		[Token(Token = "0x17000BF7")]
		public int OpponentPlayerArmsLevel
		{
			[Token(Token = "0x600B1A4")]
			[Address(RVA = "0x151D2C4", Offset = "0x151D2C4", VA = "0x7BBBD1D2C4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1A5")]
		[Address(RVA = "0x151D2CC", Offset = "0x151D2CC", VA = "0x7BBBD1D2CC")]
		public void UpdateOpponentPlayerArmsLevel(int level)
		{
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600B1A6 RID: 45478 RVA: 0x00031F50 File Offset: 0x00030150
		[Token(Token = "0x17000BF8")]
		public int UnlockItemIndex
		{
			[Token(Token = "0x600B1A6")]
			[Address(RVA = "0x151D2D4", Offset = "0x151D2D4", VA = "0x7BBBD1D2D4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600B1A7 RID: 45479 RVA: 0x00031F68 File Offset: 0x00030168
		[Token(Token = "0x17000BF9")]
		public int UnlockLevel
		{
			[Token(Token = "0x600B1A7")]
			[Address(RVA = "0x151D2DC", Offset = "0x151D2DC", VA = "0x7BBBD1D2DC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1A8")]
		[Address(RVA = "0x151D2E4", Offset = "0x151D2E4", VA = "0x7BBBD1D2E4")]
		public void UpdateEquipUnlockInfo(int unlockItemIndex, int unlockLevel)
		{
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600B1A9 RID: 45481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFA")]
		public List<uint> AllLevelEquipList
		{
			[Token(Token = "0x600B1A9")]
			[Address(RVA = "0x151D360", Offset = "0x151D360", VA = "0x7BBBD1D360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600B1AA RID: 45482 RVA: 0x00031F80 File Offset: 0x00030180
		[Token(Token = "0x17000BFB")]
		public int OneLevelSetCount
		{
			[Token(Token = "0x600B1AA")]
			[Address(RVA = "0x151D368", Offset = "0x151D368", VA = "0x7BBBD1D368")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B1AB RID: 45483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1AB")]
		[Address(RVA = "0x151D370", Offset = "0x151D370", VA = "0x7BBBD1D370")]
		public void UpdateAllLevelEquipListInfo(List<uint> list, int oneLevelSetCount)
		{
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600B1AC RID: 45484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFC")]
		public List<byte> PlayerSelectedEquipIndexList
		{
			[Token(Token = "0x600B1AC")]
			[Address(RVA = "0x151D37C", Offset = "0x151D37C", VA = "0x7BBBD1D37C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1AD")]
		[Address(RVA = "0x151D384", Offset = "0x151D384", VA = "0x7BBBD1D384")]
		public void UpdatePlayerSelectedEquipIndexList(List<byte> list)
		{
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600B1AE RID: 45486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFD")]
		public List<uint> CommonEquipSetGroup
		{
			[Token(Token = "0x600B1AE")]
			[Address(RVA = "0x151D38C", Offset = "0x151D38C", VA = "0x7BBBD1D38C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1AF")]
		[Address(RVA = "0x151D394", Offset = "0x151D394", VA = "0x7BBBD1D394")]
		public void UpdateEquipGroup(uint groupID)
		{
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1B0")]
		[Address(RVA = "0x15120C8", Offset = "0x15120C8", VA = "0x7BBBD120C8")]
		public void ClearCSSOData()
		{
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1B1")]
		[Address(RVA = "0x151D49C", Offset = "0x151D49C", VA = "0x7BBBD1D49C")]
		public void RefreshCSSOLastRoundRankList(List<byte> list)
		{
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1B2")]
		[Address(RVA = "0x151D530", Offset = "0x151D530", VA = "0x7BBBD1D530")]
		public void RefreshCSSORankList(List<byte> list)
		{
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1B3")]
		[Address(RVA = "0x151D5C4", Offset = "0x151D5C4", VA = "0x7BBBD1D5C4")]
		public void RefreshCSSOLastRoundTeamsHPList()
		{
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1B4")]
		[Address(RVA = "0x151D650", Offset = "0x151D650", VA = "0x7BBBD1D650")]
		public void RefreshCSSOTeamsHPList(List<byte> list)
		{
		}

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1B5")]
		[Address(RVA = "0x151D748", Offset = "0x151D748", VA = "0x7BBBD1D748")]
		public List<byte> GetCSSORankList()
		{
			return null;
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1B6")]
		[Address(RVA = "0x151D750", Offset = "0x151D750", VA = "0x7BBBD1D750")]
		public List<byte> GetCSSOLastRoundRankList()
		{
			return null;
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x00031F98 File Offset: 0x00030198
		[Token(Token = "0x600B1B7")]
		[Address(RVA = "0x151D758", Offset = "0x151D758", VA = "0x7BBBD1D758")]
		public int GetRankByTeamID(byte teamID)
		{
			return 0;
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x00031FB0 File Offset: 0x000301B0
		[Token(Token = "0x600B1B8")]
		[Address(RVA = "0x151D830", Offset = "0x151D830", VA = "0x7BBBD1D830")]
		public int GetLastRankByTeamID(byte teamID)
		{
			return 0;
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x00031FC8 File Offset: 0x000301C8
		[Token(Token = "0x600B1B9")]
		[Address(RVA = "0x151D908", Offset = "0x151D908", VA = "0x7BBBD1D908")]
		public byte GetTeamHPByTeamID(byte teamID)
		{
			return 0;
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x00031FE0 File Offset: 0x000301E0
		[Token(Token = "0x600B1BA")]
		[Address(RVA = "0x151DA54", Offset = "0x151DA54", VA = "0x7BBBD1DA54")]
		public byte GetLastRoundTeamHPByTeamID(byte teamID)
		{
			return 0;
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x00031FF8 File Offset: 0x000301F8
		[Token(Token = "0x600B1BB")]
		[Address(RVA = "0x151DB18", Offset = "0x151DB18", VA = "0x7BBBD1DB18")]
		public byte GetOppoTeamID({QAb\u0082~u playerID)
		{
			return 0;
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1BC")]
		[Address(RVA = "0x151DE18", Offset = "0x151DE18", VA = "0x7BBBD1DE18")]
		public void SetCSSOTeamIndex(byte teamID, int teamIndex)
		{
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1BD")]
		[Address(RVA = "0x151DE90", Offset = "0x151DE90", VA = "0x7BBBD1DE90")]
		public void ClearCSSOPlayerZoneIndex()
		{
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x00032010 File Offset: 0x00030210
		[Token(Token = "0x600B1BE")]
		[Address(RVA = "0x151DEF0", Offset = "0x151DEF0", VA = "0x7BBBD1DEF0")]
		public bool IsCSSOSameZone(Player p)
		{
			return default(bool);
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x00032028 File Offset: 0x00030228
		[Token(Token = "0x600B1BF")]
		[Address(RVA = "0x151E088", Offset = "0x151E088", VA = "0x7BBBD1E088")]
		public bool IsCSSOSameZone({QAb\u0082~u p)
		{
			return default(bool);
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1C0")]
		[Address(RVA = "0x151E1C8", Offset = "0x151E1C8", VA = "0x7BBBD1E1C8")]
		public void SetCSSOPlayerZoneIndex({QAb\u0082~u playerID, uint zoneIndex)
		{
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1C1")]
		[Address(RVA = "0x151E26C", Offset = "0x151E26C", VA = "0x7BBBD1E26C")]
		public void SetZoneIndexSpecial(uint zoneIndex, bool special)
		{
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x00032040 File Offset: 0x00030240
		[Token(Token = "0x600B1C2")]
		[Address(RVA = "0x151E2E4", Offset = "0x151E2E4", VA = "0x7BBBD1E2E4")]
		public bool IsZoneIndexSpecial(uint zoneIndex)
		{
			return default(bool);
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x00032058 File Offset: 0x00030258
		[Token(Token = "0x600B1C3")]
		[Address(RVA = "0x151D9C8", Offset = "0x151D9C8", VA = "0x7BBBD1D9C8")]
		public int GetCSSOTeamIndex(byte teamID)
		{
			return 0;
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x00032070 File Offset: 0x00030270
		[Token(Token = "0x600B1C4")]
		[Address(RVA = "0x151DD64", Offset = "0x151DD64", VA = "0x7BBBD1DD64")]
		public uint GetCSSOPlayerZoneIndex({QAb\u0082~u playerID)
		{
			return 0U;
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1C5")]
		[Address(RVA = "0x151E364", Offset = "0x151E364", VA = "0x7BBBD1E364")]
		public void ResetPlayerIds({QAb\u0082~u playerID)
		{
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1C6")]
		[Address(RVA = "0x151E750", Offset = "0x151E750", VA = "0x7BBBD1E750")]
		public string GetCSSOTeamName(byte teamID)
		{
			return null;
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x00032088 File Offset: 0x00030288
		[Token(Token = "0x600B1C7")]
		[Address(RVA = "0x151E7F8", Offset = "0x151E7F8", VA = "0x7BBBD1E7F8")]
		public uint GetCSSOTeamColor(byte teamID)
		{
			return 0U;
		}

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x000320A0 File Offset: 0x000302A0
		[Token(Token = "0x600B1C8")]
		[Address(RVA = "0x151E88C", Offset = "0x151E88C", VA = "0x7BBBD1E88C")]
		public uint GetCSSOTeamNameColor(byte teamID)
		{
			return 0U;
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1C9")]
		[Address(RVA = "0x151E920", Offset = "0x151E920", VA = "0x7BBBD1E920")]
		public string GetCSSOBBCodeTeamColor(byte teamID)
		{
			return null;
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1CA")]
		[Address(RVA = "0x151E9BC", Offset = "0x151E9BC", VA = "0x7BBBD1E9BC")]
		public void SetRoundBattleResults(List<R^L}QuT> battleResult)
		{
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x000320B8 File Offset: 0x000302B8
		[Token(Token = "0x600B1CB")]
		[Address(RVA = "0x151EAE4", Offset = "0x151EAE4", VA = "0x7BBBD1EAE4")]
		public bool GetBattleResultByTeamID(byte teamID)
		{
			return default(bool);
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1CC")]
		[Address(RVA = "0x151EB64", Offset = "0x151EB64", VA = "0x7BBBD1EB64")]
		public void ClearCSSOBattleResult()
		{
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1CD")]
		[Address(RVA = "0x151EBC4", Offset = "0x151EBC4", VA = "0x7BBBD1EBC4")]
		public void SetCSSOPlayerKillInfos(zkvLfKn msg)
		{
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1CE")]
		[Address(RVA = "0x151ED94", Offset = "0x151ED94", VA = "0x7BBBD1ED94")]
		public QTfiTeJ GetCSSOPlayerKillInfo({QAb\u0082~u playerID)
		{
			return null;
		}

		// Token: 0x0600B1CF RID: 45519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1CF")]
		[Address(RVA = "0x151EE3C", Offset = "0x151EE3C", VA = "0x7BBBD1EE3C")]
		public void SetCSSOTeamEliminateInfo(BElnWXK msg)
		{
		}

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x000320D0 File Offset: 0x000302D0
		[Token(Token = "0x600B1D0")]
		[Address(RVA = "0x151EFE0", Offset = "0x151EFE0", VA = "0x7BBBD1EFE0")]
		public byte GetCSSOTeamEliminateRound(byte teamID)
		{
			return 0;
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x000320E8 File Offset: 0x000302E8
		[Token(Token = "0x600B1D1")]
		[Address(RVA = "0x151F060", Offset = "0x151F060", VA = "0x7BBBD1F060")]
		public bool IsCSSOTeamEliminate(byte teamID)
		{
			return default(bool);
		}

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1D2")]
		[Address(RVA = "0x151F07C", Offset = "0x151F07C", VA = "0x7BBBD1F07C")]
		public string GetCSSORankString(byte teamID)
		{
			return null;
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x00032100 File Offset: 0x00030300
		[Token(Token = "0x600B1D3")]
		[Address(RVA = "0x151F124", Offset = "0x151F124", VA = "0x7BBBD1F124")]
		public int GetCSSOAliveTeamCnt()
		{
			return 0;
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D4")]
		[Address(RVA = "0x151F24C", Offset = "0x151F24C", VA = "0x7BBBD1F24C")]
		public void RecordTDShowOverEffectTime(U` type, float time)
		{
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x00032118 File Offset: 0x00030318
		[Token(Token = "0x600B1D5")]
		[Address(RVA = "0x151F2CC", Offset = "0x151F2CC", VA = "0x7BBBD1F2CC")]
		public float GetTDShowOverEffectTime(U` type)
		{
			return 0f;
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D6")]
		[Address(RVA = "0x151F37C", Offset = "0x151F37C", VA = "0x7BBBD1F37C")]
		public void RemoveTDShowOverEffectTime(U` type)
		{
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600B1D8 RID: 45528 RVA: 0x00032130 File Offset: 0x00030330
		// (set) Token: 0x0600B1D7 RID: 45527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFE")]
		public bool HideArrowOnMinimap
		{
			[Token(Token = "0x600B1D8")]
			[Address(RVA = "0x151F434", Offset = "0x151F434", VA = "0x7BBBD1F434")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A0C", Offset = "0x1146A0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B1D7")]
			[Address(RVA = "0x151F428", Offset = "0x151F428", VA = "0x7BBBD1F428")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11469FC", Offset = "0x11469FC")]
			set
			{
			}
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1D9")]
		[Address(RVA = "0x151F43C", Offset = "0x151F43C", VA = "0x7BBBD1F43C")]
		public UIModelMatch()
		{
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1DA")]
		[Address(RVA = "0x15202B4", Offset = "0x15202B4", VA = "0x7BBBD202B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146A1C", Offset = "0x1146A1C")]
		private void <RequestMatchResultViaHTTP>b__199_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B46F RID: 46191
		[Token(Token = "0x400B46F")]
		public const uint PropID_MatchTime = 2U;

		// Token: 0x0400B470 RID: 46192
		[Token(Token = "0x400B470")]
		public const uint PropID_LocalPlayerKillCount = 4U;

		// Token: 0x0400B471 RID: 46193
		[Token(Token = "0x400B471")]
		public const uint PropID_RemainingPlayer = 8U;

		// Token: 0x0400B472 RID: 46194
		[Token(Token = "0x400B472")]
		public const uint PropID_KillOccurs = 16U;

		// Token: 0x0400B473 RID: 46195
		[Token(Token = "0x400B473")]
		public const uint PropID_MedkitCountChanged = 32U;

		// Token: 0x0400B474 RID: 46196
		[Token(Token = "0x400B474")]
		public const uint PropID_PickupListChanged = 64U;

		// Token: 0x0400B475 RID: 46197
		[Token(Token = "0x400B475")]
		public const uint PropID_SniperOn = 128U;

		// Token: 0x0400B476 RID: 46198
		[Token(Token = "0x400B476")]
		public const uint PropID_RefreshMatchResult = 256U;

		// Token: 0x0400B477 RID: 46199
		[Token(Token = "0x400B477")]
		public const uint PropID_TeammateAdd = 512U;

		// Token: 0x0400B478 RID: 46200
		[Token(Token = "0x400B478")]
		public const uint PropID_TeammateDel = 1024U;

		// Token: 0x0400B479 RID: 46201
		[Token(Token = "0x400B479")]
		public const uint PropID_ObservePlayerKillCount = 2048U;

		// Token: 0x0400B47A RID: 46202
		[Token(Token = "0x400B47A")]
		public const uint PropID_ObserverPlayerChanged = 4096U;

		// Token: 0x0400B47B RID: 46203
		[Token(Token = "0x400B47B")]
		public const uint PropID_BattleInfo = 8192U;

		// Token: 0x0400B47C RID: 46204
		[Token(Token = "0x400B47C")]
		public const uint PropID_TargetPlayerKillOccurs = 16384U;

		// Token: 0x0400B47D RID: 46205
		[Token(Token = "0x400B47D")]
		public const uint PropID_TeamateKnockDown = 32768U;

		// Token: 0x0400B47E RID: 46206
		[Token(Token = "0x400B47E")]
		public const uint PropID_ObserverTeammateSwitch = 65536U;

		// Token: 0x0400B47F RID: 46207
		[Token(Token = "0x400B47F")]
		public const uint PropID_KnockOtherDown = 131072U;

		// Token: 0x0400B480 RID: 46208
		[Token(Token = "0x400B480")]
		public const uint PropID_EPRankingChange = 262144U;

		// Token: 0x0400B481 RID: 46209
		[Token(Token = "0x400B481")]
		public const uint PropID_EPRankingTopChange = 524288U;

		// Token: 0x0400B482 RID: 46210
		[Token(Token = "0x400B482")]
		public const uint PropID_RedEnvelopeInfo = 1048576U;

		// Token: 0x0400B483 RID: 46211
		[Token(Token = "0x400B483")]
		public const uint PropID_PVEEnemyRemaingCount = 2097152U;

		// Token: 0x0400B484 RID: 46212
		[Token(Token = "0x400B484")]
		public const uint PropID_PVEEnemyKillCount = 4194304U;

		// Token: 0x0400B485 RID: 46213
		[Token(Token = "0x400B485")]
		public const uint PropID_PVETurnCount = 8388608U;

		// Token: 0x0400B486 RID: 46214
		[Token(Token = "0x400B486")]
		public const uint PropID_LocalPlayerDeathCount = 16777216U;

		// Token: 0x0400B487 RID: 46215
		[Token(Token = "0x400B487")]
		public const uint PropID_ObservePlayerDeathCount = 33554432U;

		// Token: 0x0400B488 RID: 46216
		[Token(Token = "0x400B488")]
		public const uint PropID_BombMatchBombInfoChange = 67108864U;

		// Token: 0x0400B489 RID: 46217
		[Token(Token = "0x400B489")]
		public const uint PropID_BanknoteMatchUnlockInfoChange = 134217728U;

		// Token: 0x0400B48A RID: 46218
		[Token(Token = "0x400B48A")]
		public const uint KILL_FLAG_FIRST_BLOOD = 1U;

		// Token: 0x0400B48B RID: 46219
		[Token(Token = "0x400B48B")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<{QAb\u0082~u, int> m_MatchKillCount;

		// Token: 0x0400B48C RID: 46220
		[Token(Token = "0x400B48C")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<{QAb\u0082~u, int> m_MatchDeathCount;

		// Token: 0x0400B48D RID: 46221
		[Token(Token = "0x400B48D")]
		[FieldOffset(Offset = "0x28")]
		public bool IsMatchMaking;

		// Token: 0x0400B48E RID: 46222
		[Token(Token = "0x400B48E")]
		[FieldOffset(Offset = "0x2C")]
		private int m_MatchTime;

		// Token: 0x0400B48F RID: 46223
		[Token(Token = "0x400B48F")]
		[FieldOffset(Offset = "0x30")]
		private MapConfigData m_MapConfigData;

		// Token: 0x0400B490 RID: 46224
		[Token(Token = "0x400B490")]
		[FieldOffset(Offset = "0x38")]
		private bool m_EmulatorChecked;

		// Token: 0x0400B491 RID: 46225
		[Token(Token = "0x400B491")]
		[FieldOffset(Offset = "0x39")]
		private bool m_IsEmulator;

		// Token: 0x0400B492 RID: 46226
		[Token(Token = "0x400B492")]
		private const int EPBADGE_RANKING_FILTER = 10;

		// Token: 0x0400B493 RID: 46227
		[Token(Token = "0x400B493")]
		[FieldOffset(Offset = "0x40")]
		private List<EPPlayerInfo> m_ElitePassRankingList;

		// Token: 0x0400B494 RID: 46228
		[Token(Token = "0x400B494")]
		[FieldOffset(Offset = "0x48")]
		public bool SaveLocalPlayerTeammates;

		// Token: 0x0400B495 RID: 46229
		[Token(Token = "0x400B495")]
		[FieldOffset(Offset = "0x50")]
		public List<PlayerData> LocalPlayerTeammates;

		// Token: 0x0400B496 RID: 46230
		[Token(Token = "0x400B496")]
		[FieldOffset(Offset = "0x58")]
		public int MatchEndRank;

		// Token: 0x0400B497 RID: 46231
		[Token(Token = "0x400B497")]
		[FieldOffset(Offset = "0x5C")]
		public byte LocalTeamId;

		// Token: 0x0400B498 RID: 46232
		[Token(Token = "0x400B498")]
		[FieldOffset(Offset = "0x60")]
		public int Team1Score;

		// Token: 0x0400B499 RID: 46233
		[Token(Token = "0x400B499")]
		[FieldOffset(Offset = "0x64")]
		public int Team2Score;

		// Token: 0x0400B49A RID: 46234
		[Token(Token = "0x400B49A")]
		[FieldOffset(Offset = "0x68")]
		private uint m_LastTPCount;

		// Token: 0x0400B49B RID: 46235
		[Token(Token = "0x400B49B")]
		[FieldOffset(Offset = "0x6C")]
		private float m_LastTPTime;

		// Token: 0x0400B49C RID: 46236
		[Token(Token = "0x400B49C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11301EC", Offset = "0x11301EC")]
		private bool <IsChickenPlayerObserver>k__BackingField;

		// Token: 0x0400B49D RID: 46237
		[Token(Token = "0x400B49D")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11301FC", Offset = "0x11301FC")]
		private bool <IsCustomRoomSettingHideKillInfo>k__BackingField;

		// Token: 0x0400B49E RID: 46238
		[Token(Token = "0x400B49E")]
		[FieldOffset(Offset = "0x72")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113020C", Offset = "0x113020C")]
		private bool <IsCustomRoomSettingNoSkill>k__BackingField;

		// Token: 0x0400B49F RID: 46239
		[Token(Token = "0x400B49F")]
		[FieldOffset(Offset = "0x73")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113021C", Offset = "0x113021C")]
		private bool <IsCustomRoomSettingHideCloth>k__BackingField;

		// Token: 0x0400B4A0 RID: 46240
		[Token(Token = "0x400B4A0")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113022C", Offset = "0x113022C")]
		private bool <IsCustomRoomSettingUnlimitedAmmo>k__BackingField;

		// Token: 0x0400B4A1 RID: 46241
		[Token(Token = "0x400B4A1")]
		[FieldOffset(Offset = "0x75")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113023C", Offset = "0x113023C")]
		private bool <IsNoPowerGun>k__BackingField;

		// Token: 0x0400B4A2 RID: 46242
		[Token(Token = "0x400B4A2")]
		[FieldOffset(Offset = "0x76")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113024C", Offset = "0x113024C")]
		private bool <ShowingHallOverMask>k__BackingField;

		// Token: 0x0400B4A3 RID: 46243
		[Token(Token = "0x400B4A3")]
		[FieldOffset(Offset = "0x77")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113025C", Offset = "0x113025C")]
		private bool <UserControlDirty>k__BackingField;

		// Token: 0x0400B4A4 RID: 46244
		[Token(Token = "0x400B4A4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113026C", Offset = "0x113026C")]
		private bool <EnableEPRecoveryOverwrite>k__BackingField;

		// Token: 0x0400B4A5 RID: 46245
		[Token(Token = "0x400B4A5")]
		[FieldOffset(Offset = "0x80")]
		private List<{QAb\u0082~u> m_LocalTeamPlayerIDs;

		// Token: 0x0400B4A6 RID: 46246
		[Token(Token = "0x400B4A6")]
		[FieldOffset(Offset = "0x88")]
		private List<{QAb\u0082~u> m_OppoTeamPlayerIDs;

		// Token: 0x0400B4A7 RID: 46247
		[Token(Token = "0x400B4A7")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<byte, List<PlayerData>> m_TeamPlayerDic;

		// Token: 0x0400B4A8 RID: 46248
		[Token(Token = "0x400B4A8")]
		[FieldOffset(Offset = "0x98")]
		private List<ResultTeamData> m_MatchResult;

		// Token: 0x0400B4A9 RID: 46249
		[Token(Token = "0x400B4A9")]
		[FieldOffset(Offset = "0xA0")]
		private List<PlayerData> m_PlayerDataList;

		// Token: 0x0400B4AA RID: 46250
		[Token(Token = "0x400B4AA")]
		[FieldOffset(Offset = "0xA8")]
		private List<TeammateStats> m_ArmsRaceAllPlayerStats;

		// Token: 0x0400B4AB RID: 46251
		[Token(Token = "0x400B4AB")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_NeedShowExtraResultBG;

		// Token: 0x0400B4AC RID: 46252
		[Token(Token = "0x400B4AC")]
		[FieldOffset(Offset = "0xB1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113027C", Offset = "0x113027C")]
		private bool <IsBlockQuickChat>k__BackingField;

		// Token: 0x0400B4AD RID: 46253
		[Token(Token = "0x400B4AD")]
		[FieldOffset(Offset = "0xB8")]
		private ulong m_LastMatchRecordUserID;

		// Token: 0x0400B4AE RID: 46254
		[Token(Token = "0x400B4AE")]
		[FieldOffset(Offset = "0xC0")]
		private string m_LastMatchRecordUserName;

		// Token: 0x0400B4AF RID: 46255
		[Token(Token = "0x400B4AF")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_RecordedPlayer;

		// Token: 0x0400B4B0 RID: 46256
		[Token(Token = "0x400B4B0")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_HasLeaveGame;

		// Token: 0x0400B4B1 RID: 46257
		[Token(Token = "0x400B4B1")]
		[FieldOffset(Offset = "0xCC")]
		private int m_LocalPlayerKillCount;

		// Token: 0x0400B4B2 RID: 46258
		[Token(Token = "0x400B4B2")]
		[FieldOffset(Offset = "0xD0")]
		private int m_LocalPlayerDeathCount;

		// Token: 0x0400B4B3 RID: 46259
		[Token(Token = "0x400B4B3")]
		[FieldOffset(Offset = "0xD4")]
		public int LocalPlayerPendingReviveEndTimeMs;

		// Token: 0x0400B4B4 RID: 46260
		[Token(Token = "0x400B4B4")]
		[FieldOffset(Offset = "0xD8")]
		private int m_RemainingPlayerCount_max;

		// Token: 0x0400B4B5 RID: 46261
		[Token(Token = "0x400B4B5")]
		[FieldOffset(Offset = "0xDC")]
		private int m_RemainingPlayerCount;

		// Token: 0x0400B4B6 RID: 46262
		[Token(Token = "0x400B4B6")]
		[FieldOffset(Offset = "0xE0")]
		private UIModelMatch.PlayerDeadInfo m_PlayerDeadInfoData;

		// Token: 0x0400B4B7 RID: 46263
		[Token(Token = "0x400B4B7")]
		[FieldOffset(Offset = "0xE8")]
		private UIModelMatch.PlayerDeadInfo m_LocalPlayerDeadInfoData;

		// Token: 0x0400B4B8 RID: 46264
		[Token(Token = "0x400B4B8")]
		[FieldOffset(Offset = "0xF0")]
		private MatchIncome m_LastMatchData;

		// Token: 0x0400B4B9 RID: 46265
		[Token(Token = "0x400B4B9")]
		[FieldOffset(Offset = "0xF8")]
		private MatchStats m_LastMatchStats;

		// Token: 0x0400B4BA RID: 46266
		[Token(Token = "0x400B4BA")]
		[FieldOffset(Offset = "0x100")]
		private bool m_IsLowest;

		// Token: 0x0400B4BB RID: 46267
		[Token(Token = "0x400B4BB")]
		[FieldOffset(Offset = "0x101")]
		private bool m_HasPendingMatchRequest;

		// Token: 0x0400B4BC RID: 46268
		[Token(Token = "0x400B4BC")]
		[FieldOffset(Offset = "0x108")]
		private MatchStatsRes m_PendingMatchResultData;

		// Token: 0x0400B4BD RID: 46269
		[Token(Token = "0x400B4BD")]
		[FieldOffset(Offset = "0x110")]
		private List<{QAb\u0082~u> m_EmoteLeaderList;

		// Token: 0x0400B4BE RID: 46270
		[Token(Token = "0x400B4BE")]
		[FieldOffset(Offset = "0x118")]
		private {QAb\u0082~u m_LocalFollowEmoteLeader;

		// Token: 0x0400B4BF RID: 46271
		[Token(Token = "0x400B4BF")]
		[FieldOffset(Offset = "0x130")]
		private HashSet<{QAb\u0082~u> m_LikedPlayerSet;

		// Token: 0x0400B4C0 RID: 46272
		[Token(Token = "0x400B4C0")]
		[FieldOffset(Offset = "0x138")]
		private HashSet<{QAb\u0082~u> m_ReportedPlayerSet;

		// Token: 0x0400B4C1 RID: 46273
		[Token(Token = "0x400B4C1")]
		[FieldOffset(Offset = "0x140")]
		private HashSet<{QAb\u0082~u> m_RequestedPlayerSet;

		// Token: 0x0400B4C2 RID: 46274
		[Token(Token = "0x400B4C2")]
		[FieldOffset(Offset = "0x148")]
		private int m_PVERemainingEnemyCount;

		// Token: 0x0400B4C3 RID: 46275
		[Token(Token = "0x400B4C3")]
		[FieldOffset(Offset = "0x14C")]
		private int m_PVETurnCount;

		// Token: 0x0400B4C4 RID: 46276
		[Token(Token = "0x400B4C4")]
		[FieldOffset(Offset = "0x150")]
		private int m_PVEMaxTurnCount;

		// Token: 0x0400B4C5 RID: 46277
		[Token(Token = "0x400B4C5")]
		[FieldOffset(Offset = "0x154")]
		public int m_PVEEmemyKillCount;

		// Token: 0x0400B4C6 RID: 46278
		[Token(Token = "0x400B4C6")]
		[FieldOffset(Offset = "0x158")]
		private int m_CSWinTeamIdCurRound;

		// Token: 0x0400B4C7 RID: 46279
		[Token(Token = "0x400B4C7")]
		[FieldOffset(Offset = "0x15C")]
		private int m_LocalFactionID;

		// Token: 0x0400B4C8 RID: 46280
		[Token(Token = "0x400B4C8")]
		[FieldOffset(Offset = "0x160")]
		private FakeSubmitRes m_ClanMatchResult;

		// Token: 0x0400B4C9 RID: 46281
		[Token(Token = "0x400B4C9")]
		[FieldOffset(Offset = "0x168")]
		private int m_ODLocalFactionID;

		// Token: 0x0400B4CA RID: 46282
		[Token(Token = "0x400B4CA")]
		[FieldOffset(Offset = "0x16C")]
		private int m_LocalPlayerArmsLevel;

		// Token: 0x0400B4CB RID: 46283
		[Token(Token = "0x400B4CB")]
		[FieldOffset(Offset = "0x170")]
		private int m_OpponentPlayerArmsLevel;

		// Token: 0x0400B4CC RID: 46284
		[Token(Token = "0x400B4CC")]
		[FieldOffset(Offset = "0x174")]
		private int m_UnlockItemIndex;

		// Token: 0x0400B4CD RID: 46285
		[Token(Token = "0x400B4CD")]
		[FieldOffset(Offset = "0x178")]
		private int m_UnlockLevel;

		// Token: 0x0400B4CE RID: 46286
		[Token(Token = "0x400B4CE")]
		[FieldOffset(Offset = "0x180")]
		private List<uint> m_AllLevelEquipList;

		// Token: 0x0400B4CF RID: 46287
		[Token(Token = "0x400B4CF")]
		[FieldOffset(Offset = "0x188")]
		private int m_OneLevelSetCount;

		// Token: 0x0400B4D0 RID: 46288
		[Token(Token = "0x400B4D0")]
		[FieldOffset(Offset = "0x190")]
		private List<byte> m_PlayerSelectedEquipIndexList;

		// Token: 0x0400B4D1 RID: 46289
		[Token(Token = "0x400B4D1")]
		[FieldOffset(Offset = "0x198")]
		private uint m_CommonEquipSetGroupBit;

		// Token: 0x0400B4D2 RID: 46290
		[Token(Token = "0x400B4D2")]
		[FieldOffset(Offset = "0x1A0")]
		private List<uint> m_CommonEquipSetList;

		// Token: 0x0400B4D3 RID: 46291
		[Token(Token = "0x400B4D3")]
		[FieldOffset(Offset = "0x1A8")]
		private List<byte> m_CSSORankList;

		// Token: 0x0400B4D4 RID: 46292
		[Token(Token = "0x400B4D4")]
		[FieldOffset(Offset = "0x1B0")]
		private List<byte> m_CSSOLastRoundRankList;

		// Token: 0x0400B4D5 RID: 46293
		[Token(Token = "0x400B4D5")]
		[FieldOffset(Offset = "0x1B8")]
		private List<byte> m_CSSOTeamsHPList;

		// Token: 0x0400B4D6 RID: 46294
		[Token(Token = "0x400B4D6")]
		[FieldOffset(Offset = "0x1C0")]
		private List<byte> m_CSSOLastRoundTeamsHPList;

		// Token: 0x0400B4D7 RID: 46295
		[Token(Token = "0x400B4D7")]
		[FieldOffset(Offset = "0x1C8")]
		private Dictionary<byte, int> m_CSSOTeamIndexDict;

		// Token: 0x0400B4D8 RID: 46296
		[Token(Token = "0x400B4D8")]
		[FieldOffset(Offset = "0x1D0")]
		private Dictionary<{QAb\u0082~u, uint> m_CSSOPlayerZoneIndexDict;

		// Token: 0x0400B4D9 RID: 46297
		[Token(Token = "0x400B4D9")]
		[FieldOffset(Offset = "0x1D8")]
		private Dictionary<byte, bool> m_CSSOBattleResults;

		// Token: 0x0400B4DA RID: 46298
		[Token(Token = "0x400B4DA")]
		[FieldOffset(Offset = "0x1E0")]
		private Dictionary<{QAb\u0082~u, QTfiTeJ> m_CSSOPlayerKillInfos;

		// Token: 0x0400B4DB RID: 46299
		[Token(Token = "0x400B4DB")]
		[FieldOffset(Offset = "0x1E8")]
		private Dictionary<uint, bool> m_CSSOZoneIndexSpecial;

		// Token: 0x0400B4DC RID: 46300
		[Token(Token = "0x400B4DC")]
		[FieldOffset(Offset = "0x1F0")]
		private Dictionary<byte, byte> m_CSSOTeamEliminateInfo;

		// Token: 0x0400B4DD RID: 46301
		[Token(Token = "0x400B4DD")]
		[FieldOffset(Offset = "0x1F8")]
		private Dictionary<int, uint> m_CSSOTeamColorDict;

		// Token: 0x0400B4DE RID: 46302
		[Token(Token = "0x400B4DE")]
		[FieldOffset(Offset = "0x200")]
		private Dictionary<int, uint> m_CSSOTeamNameColorDict;

		// Token: 0x0400B4DF RID: 46303
		[Token(Token = "0x400B4DF")]
		[FieldOffset(Offset = "0x208")]
		private Dictionary<int, string> m_CSSOTeamBBCodeColorDict;

		// Token: 0x0400B4E0 RID: 46304
		[Token(Token = "0x400B4E0")]
		[FieldOffset(Offset = "0x210")]
		private Dictionary<int, string> m_CSSOTeamNameDict;

		// Token: 0x0400B4E1 RID: 46305
		[Token(Token = "0x400B4E1")]
		[FieldOffset(Offset = "0x218")]
		private Dictionary<int, string> m_CSSORankStringDict;

		// Token: 0x0400B4E2 RID: 46306
		[Token(Token = "0x400B4E2")]
		[FieldOffset(Offset = "0x220")]
		private Dictionary<U`, float> m_TDShowOverEffectTime;

		// Token: 0x0400B4E3 RID: 46307
		[Token(Token = "0x400B4E3")]
		[FieldOffset(Offset = "0x228")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113028C", Offset = "0x113028C")]
		private bool <HideArrowOnMinimap>k__BackingField;

		// Token: 0x02001F67 RID: 8039
		[Token(Token = "0x2001F67")]
		public class PlayerDeadInfo
		{
			// Token: 0x0600B1DB RID: 45531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1DB")]
			[Address(RVA = "0x2419554", Offset = "0x2419554", VA = "0x7BBCC19554")]
			public PlayerDeadInfo()
			{
			}

			// Token: 0x0400B4E4 RID: 46308
			[Token(Token = "0x400B4E4")]
			[FieldOffset(Offset = "0x10")]
			public string KillerName;

			// Token: 0x0400B4E5 RID: 46309
			[Token(Token = "0x400B4E5")]
			[FieldOffset(Offset = "0x18")]
			public string WeaponName;

			// Token: 0x0400B4E6 RID: 46310
			[Token(Token = "0x400B4E6")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 KillerPos;

			// Token: 0x0400B4E7 RID: 46311
			[Token(Token = "0x400B4E7")]
			[FieldOffset(Offset = "0x2C")]
			public bool KillerIsZombie;
		}

		// Token: 0x02001F68 RID: 8040
		[Token(Token = "0x2001F68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD214", Offset = "0x10FD214")]
		private sealed class <>c__DisplayClass178_0
		{
			// Token: 0x0600B1DC RID: 45532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1DC")]
			[Address(RVA = "0x2419068", Offset = "0x2419068", VA = "0x7BBCC19068")]
			public <>c__DisplayClass178_0()
			{
			}

			// Token: 0x0600B1DD RID: 45533 RVA: 0x00032148 File Offset: 0x00030348
			[Token(Token = "0x600B1DD")]
			[Address(RVA = "0x2419070", Offset = "0x2419070", VA = "0x7BBCC19070")]
			internal bool <OnAddPlayer>b__1(PlayerData a)
			{
				return default(bool);
			}

			// Token: 0x0600B1DE RID: 45534 RVA: 0x00032160 File Offset: 0x00030360
			[Token(Token = "0x600B1DE")]
			[Address(RVA = "0x2419144", Offset = "0x2419144", VA = "0x7BBCC19144")]
			internal bool <OnAddPlayer>b__0(PlayerData a)
			{
				return default(bool);
			}

			// Token: 0x0400B4E8 RID: 46312
			[Token(Token = "0x400B4E8")]
			[FieldOffset(Offset = "0x10")]
			public {QAb\u0082~u playerID;
		}

		// Token: 0x02001F69 RID: 8041
		[Token(Token = "0x2001F69")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD224", Offset = "0x10FD224")]
		private sealed class <>c__DisplayClass181_0
		{
			// Token: 0x0600B1DF RID: 45535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1DF")]
			[Address(RVA = "0x2419218", Offset = "0x2419218", VA = "0x7BBCC19218")]
			public <>c__DisplayClass181_0()
			{
			}

			// Token: 0x0600B1E0 RID: 45536 RVA: 0x00032178 File Offset: 0x00030378
			[Token(Token = "0x600B1E0")]
			[Address(RVA = "0x2419220", Offset = "0x2419220", VA = "0x7BBCC19220")]
			internal bool <GetTeammateData>b__0(PlayerData p)
			{
				return default(bool);
			}

			// Token: 0x0400B4E9 RID: 46313
			[Token(Token = "0x400B4E9")]
			[FieldOffset(Offset = "0x10")]
			public {QAb\u0082~u pid;
		}

		// Token: 0x02001F6A RID: 8042
		[Token(Token = "0x2001F6A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD234", Offset = "0x10FD234")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B1E2 RID: 45538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1E2")]
			[Address(RVA = "0x2418F58", Offset = "0x2418F58", VA = "0x7BBCC18F58")]
			public <>c()
			{
			}

			// Token: 0x0600B1E3 RID: 45539 RVA: 0x00032190 File Offset: 0x00030390
			[Token(Token = "0x600B1E3")]
			[Address(RVA = "0x2418F60", Offset = "0x2418F60", VA = "0x7BBCC18F60")]
			internal int <UpdateEPRankingList>b__186_0(EPPlayerInfo a, EPPlayerInfo b)
			{
				return 0;
			}

			// Token: 0x0600B1E4 RID: 45540 RVA: 0x000321A8 File Offset: 0x000303A8
			[Token(Token = "0x600B1E4")]
			[Address(RVA = "0x2418FD8", Offset = "0x2418FD8", VA = "0x7BBCC18FD8")]
			internal int <SetArmsRaceAllPlayerStats>b__204_0(TeammateStats a, TeammateStats b)
			{
				return 0;
			}

			// Token: 0x0600B1E5 RID: 45541 RVA: 0x000321C0 File Offset: 0x000303C0
			[Token(Token = "0x600B1E5")]
			[Address(RVA = "0x2419020", Offset = "0x2419020", VA = "0x7BBCC19020")]
			internal int <GenerateMatchResult>b__216_0(ResultTeamData a, ResultTeamData b)
			{
				return 0;
			}

			// Token: 0x0400B4EA RID: 46314
			[Token(Token = "0x400B4EA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelMatch.<>c <>9;

			// Token: 0x0400B4EB RID: 46315
			[Token(Token = "0x400B4EB")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<EPPlayerInfo> <>9__186_0;

			// Token: 0x0400B4EC RID: 46316
			[Token(Token = "0x400B4EC")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<TeammateStats> <>9__204_0;

			// Token: 0x0400B4ED RID: 46317
			[Token(Token = "0x400B4ED")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<ResultTeamData> <>9__216_0;
		}

		// Token: 0x02001F6B RID: 8043
		[Token(Token = "0x2001F6B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD244", Offset = "0x10FD244")]
		private sealed class <>c__DisplayClass192_0
		{
			// Token: 0x0600B1E6 RID: 45542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1E6")]
			[Address(RVA = "0x24192F4", Offset = "0x24192F4", VA = "0x7BBCC192F4")]
			public <>c__DisplayClass192_0()
			{
			}

			// Token: 0x0600B1E7 RID: 45543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1E7")]
			[Address(RVA = "0x24192FC", Offset = "0x24192FC", VA = "0x7BBCC192FC")]
			internal void <RequestStartMatchMaking>b__0(ResErrorCode error, ResDownloadType download_type)
			{
			}

			// Token: 0x0400B4EE RID: 46318
			[Token(Token = "0x400B4EE")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMatch <>4__this;

			// Token: 0x0400B4EF RID: 46319
			[Token(Token = "0x400B4EF")]
			[FieldOffset(Offset = "0x18")]
			public uint map_id;

			// Token: 0x0400B4F0 RID: 46320
			[Token(Token = "0x400B4F0")]
			[FieldOffset(Offset = "0x1C")]
			public l}BQs\u0080\u0082 game_mode;

			// Token: 0x0400B4F1 RID: 46321
			[Token(Token = "0x400B4F1")]
			[FieldOffset(Offset = "0x20")]
			public f match_mode;

			// Token: 0x0400B4F2 RID: 46322
			[Token(Token = "0x400B4F2")]
			[FieldOffset(Offset = "0x24")]
			public uint map_difficulty;

			// Token: 0x0400B4F3 RID: 46323
			[Token(Token = "0x400B4F3")]
			[FieldOffset(Offset = "0x28")]
			public bool isRandomMap;
		}

		// Token: 0x02001F6C RID: 8044
		[Token(Token = "0x2001F6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD254", Offset = "0x10FD254")]
		private sealed class <>c__DisplayClass219_0
		{
			// Token: 0x0600B1E8 RID: 45544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1E8")]
			[Address(RVA = "0x2419404", Offset = "0x2419404", VA = "0x7BBCC19404")]
			public <>c__DisplayClass219_0()
			{
			}

			// Token: 0x0600B1E9 RID: 45545 RVA: 0x000321D8 File Offset: 0x000303D8
			[Token(Token = "0x600B1E9")]
			[Address(RVA = "0x241940C", Offset = "0x241940C", VA = "0x7BBCC1940C")]
			internal bool <GetPlayerDataByAccountID>b__0(PlayerData p)
			{
				return default(bool);
			}

			// Token: 0x0400B4F4 RID: 46324
			[Token(Token = "0x400B4F4")]
			[FieldOffset(Offset = "0x10")]
			public ulong accountID;
		}

		// Token: 0x02001F6D RID: 8045
		[Token(Token = "0x2001F6D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD264", Offset = "0x10FD264")]
		private sealed class <>c__DisplayClass220_0
		{
			// Token: 0x0600B1EA RID: 45546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1EA")]
			[Address(RVA = "0x2419448", Offset = "0x2419448", VA = "0x7BBCC19448")]
			public <>c__DisplayClass220_0()
			{
			}

			// Token: 0x0600B1EB RID: 45547 RVA: 0x000321F0 File Offset: 0x000303F0
			[Token(Token = "0x600B1EB")]
			[Address(RVA = "0x2419450", Offset = "0x2419450", VA = "0x7BBCC19450")]
			internal bool <GetPlayerDataByPlayerID>b__0(PlayerData p)
			{
				return default(bool);
			}

			// Token: 0x0400B4F5 RID: 46325
			[Token(Token = "0x400B4F5")]
			[FieldOffset(Offset = "0x10")]
			public {QAb\u0082~u playerID;
		}

		// Token: 0x02001F6E RID: 8046
		[Token(Token = "0x2001F6E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD274", Offset = "0x10FD274")]
		private sealed class <>c__DisplayClass326_0
		{
			// Token: 0x0600B1EC RID: 45548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1EC")]
			[Address(RVA = "0x2419524", Offset = "0x2419524", VA = "0x7BBCC19524")]
			public <>c__DisplayClass326_0()
			{
			}

			// Token: 0x0600B1ED RID: 45549 RVA: 0x00032208 File Offset: 0x00030408
			[Token(Token = "0x600B1ED")]
			[Address(RVA = "0x241952C", Offset = "0x241952C", VA = "0x7BBCC1952C")]
			internal bool <GetRankByTeamID>b__0(byte t)
			{
				return default(bool);
			}

			// Token: 0x0400B4F6 RID: 46326
			[Token(Token = "0x400B4F6")]
			[FieldOffset(Offset = "0x10")]
			public byte teamID;
		}

		// Token: 0x02001F6F RID: 8047
		[Token(Token = "0x2001F6F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD284", Offset = "0x10FD284")]
		private sealed class <>c__DisplayClass327_0
		{
			// Token: 0x0600B1EE RID: 45550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B1EE")]
			[Address(RVA = "0x241953C", Offset = "0x241953C", VA = "0x7BBCC1953C")]
			public <>c__DisplayClass327_0()
			{
			}

			// Token: 0x0600B1EF RID: 45551 RVA: 0x00032220 File Offset: 0x00030420
			[Token(Token = "0x600B1EF")]
			[Address(RVA = "0x2419544", Offset = "0x2419544", VA = "0x7BBCC19544")]
			internal bool <GetLastRankByTeamID>b__0(byte t)
			{
				return default(bool);
			}

			// Token: 0x0400B4F7 RID: 46327
			[Token(Token = "0x400B4F7")]
			[FieldOffset(Offset = "0x10")]
			public byte teamID;
		}
	}
}
