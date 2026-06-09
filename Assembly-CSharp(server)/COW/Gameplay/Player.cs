using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using TsiU;
using UMA;
using UnityEngine;
using UnityEngine.AI;

namespace COW.GamePlay
{
	// Token: 0x02002A59 RID: 10841
	[Token(Token = "0x2002A59")]
	internal class Player : AttackableEntity, \u007F{KyDPR, AbDr`s, IReusableObjectOwner, YqufY|Y
	{
		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x0600E95D RID: 59741 RVA: 0x000418B0 File Offset: 0x0003FAB0
		// (set) Token: 0x0600E95C RID: 59740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE6")]
		public bool AXao[ad
		{
			[Token(Token = "0x600E95D")]
			[Address(RVA = "0x12E1270", Offset = "0x12E1270", VA = "0x7BBBAE1270")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E95C")]
			[Address(RVA = "0x12D2148", Offset = "0x12D2148", VA = "0x7BBBAD2148")]
			set
			{
			}
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E95E")]
		[Address(RVA = "0x12E1278", Offset = "0x12E1278", VA = "0x7BBBAE1278")]
		public void AddEPSurroundEffect(int EmJdfCs = 1, bool WoCfBgE = true)
		{
		}

		// Token: 0x0600E95F RID: 59743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E95F")]
		[Address(RVA = "0x12E159C", Offset = "0x12E159C", VA = "0x7BBBAE159C")]
		public void AddEPPlayerEffect()
		{
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E960")]
		[Address(RVA = "0x12E18A4", Offset = "0x12E18A4", VA = "0x7BBBAE18A4")]
		protected void QQAoFJh()
		{
		}

		// Token: 0x0600E961 RID: 59745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E961")]
		[Address(RVA = "0x12E1B94", Offset = "0x12E1B94", VA = "0x7BBBAE1B94")]
		public void SyncRevengeInfo(\u007FGCjICM ~S`Xinb)
		{
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E962")]
		[Address(RVA = "0x12E1C90", Offset = "0x12E1C90", VA = "0x7BBBAE1C90")]
		public void SyncRevengersInfo(X\u0081]\u0082qoa ~S`Xinb)
		{
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E963")]
		[Address(RVA = "0x12E1FB4", Offset = "0x12E1FB4", VA = "0x7BBBAE1FB4")]
		public void UpdateRevengeStatus(bool vwFoy{v = false)
		{
		}

		// Token: 0x0600E964 RID: 59748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E964")]
		[Address(RVA = "0x12E24E4", Offset = "0x12E24E4", VA = "0x7BBBAE24E4")]
		public void EnableCrossWindowEffect(bool K`OU\u0080vI)
		{
		}

		// Token: 0x0600E965 RID: 59749 RVA: 0x000418C8 File Offset: 0x0003FAC8
		[Token(Token = "0x600E965")]
		[Address(RVA = "0x12E24E8", Offset = "0x12E24E8", VA = "0x7BBBAE24E8", Slot = "43")]
		public override Vector3 GetAttackableCenterWS()
		{
			return default(Vector3);
		}

		// Token: 0x0600E966 RID: 59750 RVA: 0x000418E0 File Offset: 0x0003FAE0
		[Token(Token = "0x600E966")]
		[Address(RVA = "0x12E27C8", Offset = "0x12E27C8", VA = "0x7BBBAE27C8", Slot = "44")]
		public override float GetAttackableRadius()
		{
			return 0f;
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x000418F8 File Offset: 0x0003FAF8
		[Token(Token = "0x600E967")]
		[Address(RVA = "0x12E27F8", Offset = "0x12E27F8", VA = "0x7BBBAE27F8")]
		public uint GenerateLocalDamgeProjectileID()
		{
			return 0U;
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x0600E968 RID: 59752 RVA: 0x00041910 File Offset: 0x0003FB10
		// (set) Token: 0x0600E969 RID: 59753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE7")]
		public ulong Ml}sm\u0080D
		{
			[Token(Token = "0x600E968")]
			[Address(RVA = "0x12E2860", Offset = "0x12E2860", VA = "0x7BBBAE2860")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600E969")]
			[Address(RVA = "0x12E2868", Offset = "0x12E2868", VA = "0x7BBBAE2868")]
			protected set
			{
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x0600E96A RID: 59754 RVA: 0x00041928 File Offset: 0x0003FB28
		// (set) Token: 0x0600E96B RID: 59755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE8")]
		public {QAb\u0082~u {QAb\u0082~u
		{
			[Token(Token = "0x600E96A")]
			[Address(RVA = "0x12E125C", Offset = "0x12E125C", VA = "0x7BBBAE125C", Slot = "62")]
			get
			{
				return default({QAb\u0082~u);
			}
			[Token(Token = "0x600E96B")]
			[Address(RVA = "0x12E2870", Offset = "0x12E2870", VA = "0x7BBBAE2870")]
			protected set
			{
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x0600E96C RID: 59756 RVA: 0x00041940 File Offset: 0x0003FB40
		// (set) Token: 0x0600E96D RID: 59757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE9")]
		public ulong TBOETDe
		{
			[Token(Token = "0x600E96C")]
			[Address(RVA = "0x12E2884", Offset = "0x12E2884", VA = "0x7BBBAE2884")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600E96D")]
			[Address(RVA = "0x12E288C", Offset = "0x12E288C", VA = "0x7BBBAE288C")]
			protected set
			{
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x0600E96E RID: 59758 RVA: 0x00041958 File Offset: 0x0003FB58
		[Token(Token = "0x17000FEA")]
		public ulong uPuSWFy
		{
			[Token(Token = "0x600E96E")]
			[Address(RVA = "0x12E2894", Offset = "0x12E2894", VA = "0x7BBBAE2894")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x0600E96F RID: 59759 RVA: 0x00041970 File Offset: 0x0003FB70
		// (set) Token: 0x0600E970 RID: 59760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FEB")]
		public int uvxg\u0080cc
		{
			[Token(Token = "0x600E96F")]
			[Address(RVA = "0x12E289C", Offset = "0x12E289C", VA = "0x7BBBAE289C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A240", Offset = "0x114A240")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600E970")]
			[Address(RVA = "0x12E28A4", Offset = "0x12E28A4", VA = "0x7BBBAE28A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A250", Offset = "0x114A250")]
			set
			{
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x0600E972 RID: 59762 RVA: 0x00041988 File Offset: 0x0003FB88
		// (set) Token: 0x0600E971 RID: 59761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FEC")]
		public {QAb\u0082~u Y|^ewL{
		{
			[Token(Token = "0x600E972")]
			[Address(RVA = "0x12E28C0", Offset = "0x12E28C0", VA = "0x7BBBAE28C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A270", Offset = "0x114A270")]
			get
			{
				return default({QAb\u0082~u);
			}
			[Token(Token = "0x600E971")]
			[Address(RVA = "0x12E28AC", Offset = "0x12E28AC", VA = "0x7BBBAE28AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A260", Offset = "0x114A260")]
			protected set
			{
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x0600E973 RID: 59763 RVA: 0x000419A0 File Offset: 0x0003FBA0
		// (set) Token: 0x0600E974 RID: 59764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FED")]
		public uint oV\u007FEr^I
		{
			[Token(Token = "0x600E973")]
			[Address(RVA = "0x12E28D4", Offset = "0x12E28D4", VA = "0x7BBBAE28D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A280", Offset = "0x114A280")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600E974")]
			[Address(RVA = "0x12E28DC", Offset = "0x12E28DC", VA = "0x7BBBAE28DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A290", Offset = "0x114A290")]
			set
			{
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x0600E975 RID: 59765 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E976 RID: 59766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FEE")]
		public string ^]G\u0082UOk
		{
			[Token(Token = "0x600E975")]
			[Address(RVA = "0x12E28E4", Offset = "0x12E28E4", VA = "0x7BBBAE28E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A2A0", Offset = "0x114A2A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600E976")]
			[Address(RVA = "0x12E28EC", Offset = "0x12E28EC", VA = "0x7BBBAE28EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A2B0", Offset = "0x114A2B0")]
			set
			{
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x0600E977 RID: 59767 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E978 RID: 59768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FEF")]
		public string AdYQo~B
		{
			[Token(Token = "0x600E977")]
			[Address(RVA = "0x12E28F4", Offset = "0x12E28F4", VA = "0x7BBBAE28F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A2C0", Offset = "0x114A2C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600E978")]
			[Address(RVA = "0x12E28FC", Offset = "0x12E28FC", VA = "0x7BBBAE28FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A2D0", Offset = "0x114A2D0")]
			set
			{
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x0600E979 RID: 59769 RVA: 0x000419B8 File Offset: 0x0003FBB8
		// (set) Token: 0x0600E97A RID: 59770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FF0")]
		public uint nV~ioMX
		{
			[Token(Token = "0x600E979")]
			[Address(RVA = "0x12E2904", Offset = "0x12E2904", VA = "0x7BBBAE2904")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A2E0", Offset = "0x114A2E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600E97A")]
			[Address(RVA = "0x12E290C", Offset = "0x12E290C", VA = "0x7BBBAE290C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A2F0", Offset = "0x114A2F0")]
			set
			{
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x0600E97B RID: 59771 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E97C RID: 59772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FF1")]
		public object co]jhGn
		{
			[Token(Token = "0x600E97B")]
			[Address(RVA = "0x12E2914", Offset = "0x12E2914", VA = "0x7BBBAE2914")]
			get
			{
				return null;
			}
			[Token(Token = "0x600E97C")]
			[Address(RVA = "0x12E291C", Offset = "0x12E291C", VA = "0x7BBBAE291C")]
			protected set
			{
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x0600E97D RID: 59773 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E97E RID: 59774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FF2")]
		public string iJFDXGv
		{
			[Token(Token = "0x600E97D")]
			[Address(RVA = "0x12E2924", Offset = "0x12E2924", VA = "0x7BBBAE2924")]
			get
			{
				return null;
			}
			[Token(Token = "0x600E97E")]
			[Address(RVA = "0x12E292C", Offset = "0x12E292C", VA = "0x7BBBAE292C")]
			protected set
			{
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x0600E97F RID: 59775 RVA: 0x000419D0 File Offset: 0x0003FBD0
		// (set) Token: 0x0600E980 RID: 59776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FF3")]
		public bool <<EMPTY_NAME>>
		{
			[Token(Token = "0x600E97F")]
			[Address(RVA = "0x12E2934", Offset = "0x12E2934", VA = "0x7BBBAE2934")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A300", Offset = "0x114A300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E980")]
			[Address(RVA = "0x12E293C", Offset = "0x12E293C", VA = "0x7BBBAE293C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A310", Offset = "0x114A310")]
			set
			{
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x0600E981 RID: 59777 RVA: 0x000419E8 File Offset: 0x0003FBE8
		[Token(Token = "0x17000FF4")]
		public bool qLm[SCW
		{
			[Token(Token = "0x600E981")]
			[Address(RVA = "0x12E2948", Offset = "0x12E2948", VA = "0x7BBBAE2948")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x0600E982 RID: 59778 RVA: 0x00041A00 File Offset: 0x0003FC00
		[Token(Token = "0x17000FF5")]
		public bool e]\u0081Zi]Q
		{
			[Token(Token = "0x600E982")]
			[Address(RVA = "0x12E2A6C", Offset = "0x12E2A6C", VA = "0x7BBBAE2A6C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x0600E983 RID: 59779 RVA: 0x00041A18 File Offset: 0x0003FC18
		[Token(Token = "0x17000FF6")]
		public bool pzoLeyg
		{
			[Token(Token = "0x600E983")]
			[Address(RVA = "0x12E2B0C", Offset = "0x12E2B0C", VA = "0x7BBBAE2B0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x0600E984 RID: 59780 RVA: 0x00041A30 File Offset: 0x0003FC30
		[Token(Token = "0x17000FF7")]
		public bool ]X^[}UF
		{
			[Token(Token = "0x600E984")]
			[Address(RVA = "0x12E2B4C", Offset = "0x12E2B4C", VA = "0x7BBBAE2B4C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x0600E985 RID: 59781 RVA: 0x00041A48 File Offset: 0x0003FC48
		// (set) Token: 0x0600E986 RID: 59782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FF8")]
		public bool XK}~GrG
		{
			[Token(Token = "0x600E985")]
			[Address(RVA = "0x12E2BEC", Offset = "0x12E2BEC", VA = "0x7BBBAE2BEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E986")]
			[Address(RVA = "0x12E2BF4", Offset = "0x12E2BF4", VA = "0x7BBBAE2BF4")]
			protected set
			{
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600E987 RID: 59783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF9")]
		public CharacterController Yep{m^L
		{
			[Token(Token = "0x600E987")]
			[Address(RVA = "0x12E05C0", Offset = "0x12E05C0", VA = "0x7BBBAE05C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x0600E989 RID: 59785 RVA: 0x00041A60 File Offset: 0x0003FC60
		// (set) Token: 0x0600E988 RID: 59784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FFA")]
		public bool AzwTdll
		{
			[Token(Token = "0x600E989")]
			[Address(RVA = "0x12E2C0C", Offset = "0x12E2C0C", VA = "0x7BBBAE2C0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E988")]
			[Address(RVA = "0x12E2C00", Offset = "0x12E2C00", VA = "0x7BBBAE2C00")]
			set
			{
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x0600E98B RID: 59787 RVA: 0x00041A78 File Offset: 0x0003FC78
		// (set) Token: 0x0600E98A RID: 59786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FFB")]
		public bool UUPM\u0082Tu
		{
			[Token(Token = "0x600E98B")]
			[Address(RVA = "0x12E2C20", Offset = "0x12E2C20", VA = "0x7BBBAE2C20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E98A")]
			[Address(RVA = "0x12E2C14", Offset = "0x12E2C14", VA = "0x7BBBAE2C14")]
			set
			{
			}
		}

		// Token: 0x0600E98C RID: 59788 RVA: 0x00041A90 File Offset: 0x0003FC90
		[Token(Token = "0x600E98C")]
		[Address(RVA = "0x12E2C28", Offset = "0x12E2C28", VA = "0x7BBBAE2C28")]
		public uint GenUniqueID()
		{
			return 0U;
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x0600E98D RID: 59789 RVA: 0x00041AA8 File Offset: 0x0003FCA8
		[Token(Token = "0x17000FFC")]
		public bool YnzQRkD
		{
			[Token(Token = "0x600E98D")]
			[Address(RVA = "0x12CEB60", Offset = "0x12CEB60", VA = "0x7BBBACEB60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x0600E98E RID: 59790 RVA: 0x00041AC0 File Offset: 0x0003FCC0
		// (set) Token: 0x0600E98F RID: 59791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FFD")]
		public bool gGobiZc
		{
			[Token(Token = "0x600E98E")]
			[Address(RVA = "0x12CEB68", Offset = "0x12CEB68", VA = "0x7BBBACEB68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A320", Offset = "0x114A320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E98F")]
			[Address(RVA = "0x12E2C3C", Offset = "0x12E2C3C", VA = "0x7BBBAE2C3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A330", Offset = "0x114A330")]
			protected set
			{
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x0600E990 RID: 59792 RVA: 0x00041AD8 File Offset: 0x0003FCD8
		// (set) Token: 0x0600E991 RID: 59793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FFE")]
		public bool xg~l
		{
			[Token(Token = "0x600E990")]
			[Address(RVA = "0x12CED10", Offset = "0x12CED10", VA = "0x7BBBACED10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A340", Offset = "0x114A340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E991")]
			[Address(RVA = "0x12E2C48", Offset = "0x12E2C48", VA = "0x7BBBAE2C48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A350", Offset = "0x114A350")]
			set
			{
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x0600E992 RID: 59794 RVA: 0x00041AF0 File Offset: 0x0003FCF0
		// (set) Token: 0x0600E993 RID: 59795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FFF")]
		public bool HFKeH|\u007F
		{
			[Token(Token = "0x600E992")]
			[Address(RVA = "0x12CED18", Offset = "0x12CED18", VA = "0x7BBBACED18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A360", Offset = "0x114A360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E993")]
			[Address(RVA = "0x12E2C54", Offset = "0x12E2C54", VA = "0x7BBBAE2C54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A370", Offset = "0x114A370")]
			set
			{
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x0600E994 RID: 59796 RVA: 0x00041B08 File Offset: 0x0003FD08
		// (set) Token: 0x0600E995 RID: 59797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001000")]
		public bool JBQW
		{
			[Token(Token = "0x600E994")]
			[Address(RVA = "0x12E2C60", Offset = "0x12E2C60", VA = "0x7BBBAE2C60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A380", Offset = "0x114A380")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E995")]
			[Address(RVA = "0x12E2C68", Offset = "0x12E2C68", VA = "0x7BBBAE2C68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A390", Offset = "0x114A390")]
			set
			{
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600E996 RID: 59798 RVA: 0x00041B20 File Offset: 0x0003FD20
		[Token(Token = "0x17001001")]
		public bool znzkG|Y
		{
			[Token(Token = "0x600E996")]
			[Address(RVA = "0x12CEB70", Offset = "0x12CEB70", VA = "0x7BBBACEB70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x0600E997 RID: 59799 RVA: 0x00041B38 File Offset: 0x0003FD38
		[Token(Token = "0x17001002")]
		public bool RO~GGJJ
		{
			[Token(Token = "0x600E997")]
			[Address(RVA = "0x12CEC54", Offset = "0x12CEC54", VA = "0x7BBBACEC54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x0600E998 RID: 59800 RVA: 0x00041B50 File Offset: 0x0003FD50
		// (set) Token: 0x0600E999 RID: 59801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001003")]
		public bool \u0080fXtAC^
		{
			[Token(Token = "0x600E998")]
			[Address(RVA = "0x12E2C74", Offset = "0x12E2C74", VA = "0x7BBBAE2C74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A3A0", Offset = "0x114A3A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E999")]
			[Address(RVA = "0x12D6564", Offset = "0x12D6564", VA = "0x7BBBAD6564")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A3B0", Offset = "0x114A3B0")]
			set
			{
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x0600E99A RID: 59802 RVA: 0x00041B68 File Offset: 0x0003FD68
		// (set) Token: 0x0600E99B RID: 59803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001004")]
		public uint \u007FDNne\u007FN
		{
			[Token(Token = "0x600E99A")]
			[Address(RVA = "0x12E2C7C", Offset = "0x12E2C7C", VA = "0x7BBBAE2C7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A3C0", Offset = "0x114A3C0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600E99B")]
			[Address(RVA = "0x12E2C84", Offset = "0x12E2C84", VA = "0x7BBBAE2C84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A3D0", Offset = "0x114A3D0")]
			set
			{
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x0600E99C RID: 59804 RVA: 0x00041B80 File Offset: 0x0003FD80
		[Token(Token = "0x17001005")]
		public uint PHSdknf
		{
			[Token(Token = "0x600E99C")]
			[Address(RVA = "0x12CF6F8", Offset = "0x12CF6F8", VA = "0x7BBBACF6F8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600E99D RID: 59805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E99D")]
		[Address(RVA = "0x12E2C8C", Offset = "0x12E2C8C", VA = "0x7BBBAE2C8C")]
		public void SetBooyahEmotionID(uint {NRR\u0081yd)
		{
		}

		// Token: 0x0600E99E RID: 59806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E99E")]
		[Address(RVA = "0x12E2C94", Offset = "0x12E2C94", VA = "0x7BBBAE2C94")]
		public void RequireFollowCameraRotationUpdateTracing()
		{
		}

		// Token: 0x0600E99F RID: 59807 RVA: 0x00041B98 File Offset: 0x0003FD98
		[Token(Token = "0x600E99F")]
		[Address(RVA = "0x12E2CA4", Offset = "0x12E2CA4", VA = "0x7BBBAE2CA4")]
		public bool IsTracingFollowCameraRotationUpdate()
		{
			return default(bool);
		}

		// Token: 0x0600E9A0 RID: 59808 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		[Token(Token = "0x600E9A0")]
		[Address(RVA = "0x12E2CAC", Offset = "0x12E2CAC", VA = "0x7BBBAE2CAC")]
		public bool IsFollowCameraRotationUpdateTracingFinished()
		{
			return default(bool);
		}

		// Token: 0x0600E9A1 RID: 59809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A1")]
		[Address(RVA = "0x12E2CB4", Offset = "0x12E2CB4", VA = "0x7BBBAE2CB4")]
		public void UpdateFollowCameraRotationUpdateTracing(bool OH|Zs~i, bool Vp~oa`A)
		{
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x0600E9A3 RID: 59811 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		// (set) Token: 0x0600E9A2 RID: 59810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001006")]
		public bool r^X[{co
		{
			[Token(Token = "0x600E9A3")]
			[Address(RVA = "0x12D655C", Offset = "0x12D655C", VA = "0x7BBBAD655C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9A2")]
			[Address(RVA = "0x12D8578", Offset = "0x12D8578", VA = "0x7BBBAD8578")]
			set
			{
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x0600E9A4 RID: 59812 RVA: 0x00041BE0 File Offset: 0x0003FDE0
		// (set) Token: 0x0600E9A5 RID: 59813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001007")]
		public bool pmbfOqL
		{
			[Token(Token = "0x600E9A4")]
			[Address(RVA = "0x12E2E48", Offset = "0x12E2E48", VA = "0x7BBBAE2E48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9A5")]
			[Address(RVA = "0x12E2E50", Offset = "0x12E2E50", VA = "0x7BBBAE2E50")]
			set
			{
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x0600E9A6 RID: 59814 RVA: 0x00041BF8 File Offset: 0x0003FDF8
		// (set) Token: 0x0600E9A7 RID: 59815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001008")]
		public bool XUMR^{\u0080
		{
			[Token(Token = "0x600E9A6")]
			[Address(RVA = "0x12E2E5C", Offset = "0x12E2E5C", VA = "0x7BBBAE2E5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A3E0", Offset = "0x114A3E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9A7")]
			[Address(RVA = "0x12E2E64", Offset = "0x12E2E64", VA = "0x7BBBAE2E64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A3F0", Offset = "0x114A3F0")]
			private set
			{
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600E9A8 RID: 59816 RVA: 0x00041C10 File Offset: 0x0003FE10
		[Token(Token = "0x17001009")]
		public EAimAssist Kp]VkK{
		{
			[Token(Token = "0x600E9A8")]
			[Address(RVA = "0x12E2E70", Offset = "0x12E2E70", VA = "0x7BBBAE2E70")]
			get
			{
				return EAimAssist.AllOn;
			}
		}

		// Token: 0x0600E9A9 RID: 59817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9A9")]
		[Address(RVA = "0x12E2E78", Offset = "0x12E2E78", VA = "0x7BBBAE2E78")]
		public void SetEAimAssitMode(EAimAssist `bb[\u0082We)
		{
		}

		// Token: 0x0600E9AA RID: 59818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9AA")]
		[Address(RVA = "0x12E2E80", Offset = "0x12E2E80", VA = "0x7BBBAE2E80")]
		public V GetAimAssistOnSighting()
		{
			return null;
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600E9AB RID: 59819 RVA: 0x00041C28 File Offset: 0x0003FE28
		[Token(Token = "0x1700100A")]
		public bool lZbk}\u0080\u007F
		{
			[Token(Token = "0x600E9AB")]
			[Address(RVA = "0x12CA4B8", Offset = "0x12CA4B8", VA = "0x7BBBACA4B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E9AC RID: 59820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9AC")]
		[Address(RVA = "0x12E2EF0", Offset = "0x12E2EF0", VA = "0x7BBBAE2EF0")]
		public CbeeJ GetResureStatus()
		{
			return null;
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600E9AD RID: 59821 RVA: 0x00041C40 File Offset: 0x0003FE40
		[Token(Token = "0x1700100B")]
		public bool Ave^hRW
		{
			[Token(Token = "0x600E9AD")]
			[Address(RVA = "0x12E2EF8", Offset = "0x12E2EF8", VA = "0x7BBBAE2EF8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x0600E9AE RID: 59822 RVA: 0x00041C58 File Offset: 0x0003FE58
		[Token(Token = "0x1700100C")]
		public bool hOtIAeq
		{
			[Token(Token = "0x600E9AE")]
			[Address(RVA = "0x12E2F24", Offset = "0x12E2F24", VA = "0x7BBBAE2F24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x0600E9AF RID: 59823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700100D")]
		public FollowCamera Yo~QYe~
		{
			[Token(Token = "0x600E9AF")]
			[Address(RVA = "0x12E2F50", Offset = "0x12E2F50", VA = "0x7BBBAE2F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600E9B0 RID: 59824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700100E")]
		public virtual Collider \u0080Ij~cm[
		{
			[Token(Token = "0x600E9B0")]
			[Address(RVA = "0x12E3020", Offset = "0x12E3020", VA = "0x7BBBAE3020", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600E9B1 RID: 59825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700100F")]
		public NewPlayerAnimationSystemComponent {hCSOcL
		{
			[Token(Token = "0x600E9B1")]
			[Address(RVA = "0x12DA49C", Offset = "0x12DA49C", VA = "0x7BBBADA49C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600E9B2 RID: 59826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001010")]
		public AvatarManager nzkCI[E
		{
			[Token(Token = "0x600E9B2")]
			[Address(RVA = "0x12E3028", Offset = "0x12E3028", VA = "0x7BBBAE3028")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E9B3 RID: 59827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9B3")]
		[Address(RVA = "0x12E3030", Offset = "0x12E3030", VA = "0x7BBBAE3030")]
		public AvatarManager GetAvatarManager()
		{
			return null;
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x0600E9B4 RID: 59828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001011")]
		public PlayerAttributes [zDdaOY
		{
			[Token(Token = "0x600E9B4")]
			[Address(RVA = "0x12D1AD8", Offset = "0x12D1AD8", VA = "0x7BBBAD1AD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x0600E9B5 RID: 59829 RVA: 0x00041C70 File Offset: 0x0003FE70
		// (set) Token: 0x0600E9B6 RID: 59830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001012")]
		public bool hDTDQNX
		{
			[Token(Token = "0x600E9B5")]
			[Address(RVA = "0x12E3038", Offset = "0x12E3038", VA = "0x7BBBAE3038")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A400", Offset = "0x114A400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9B6")]
			[Address(RVA = "0x12E3040", Offset = "0x12E3040", VA = "0x7BBBAE3040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A410", Offset = "0x114A410")]
			set
			{
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x0600E9B7 RID: 59831 RVA: 0x00041C88 File Offset: 0x0003FE88
		// (set) Token: 0x0600E9B8 RID: 59832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001013")]
		public bool IPIY
		{
			[Token(Token = "0x600E9B7")]
			[Address(RVA = "0x12E304C", Offset = "0x12E304C", VA = "0x7BBBAE304C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A420", Offset = "0x114A420")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9B8")]
			[Address(RVA = "0x12E3054", Offset = "0x12E3054", VA = "0x7BBBAE3054")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A430", Offset = "0x114A430")]
			set
			{
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x0600E9B9 RID: 59833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001014")]
		public Transform \u0082VqbRwK
		{
			[Token(Token = "0x600E9B9")]
			[Address(RVA = "0x12E3060", Offset = "0x12E3060", VA = "0x7BBBAE3060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x0600E9BA RID: 59834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001015")]
		public Transform {i^VO\u0081W
		{
			[Token(Token = "0x600E9BA")]
			[Address(RVA = "0x12E3068", Offset = "0x12E3068", VA = "0x7BBBAE3068")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x0600E9BB RID: 59835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001016")]
		public NavMeshAgent w]WiyZF
		{
			[Token(Token = "0x600E9BB")]
			[Address(RVA = "0x12E3070", Offset = "0x12E3070", VA = "0x7BBBAE3070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x0600E9BC RID: 59836 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E9BD RID: 59837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001017")]
		public NetworkPet v[vh\u007FLA
		{
			[Token(Token = "0x600E9BC")]
			[Address(RVA = "0x12E3078", Offset = "0x12E3078", VA = "0x7BBBAE3078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A440", Offset = "0x114A440")]
			get
			{
				return null;
			}
			[Token(Token = "0x600E9BD")]
			[Address(RVA = "0x12E3080", Offset = "0x12E3080", VA = "0x7BBBAE3080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A450", Offset = "0x114A450")]
			set
			{
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600E9BF RID: 59839 RVA: 0x00041CA0 File Offset: 0x0003FEA0
		// (set) Token: 0x0600E9BE RID: 59838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001018")]
		public bool G\u0080plnxK
		{
			[Token(Token = "0x600E9BF")]
			[Address(RVA = "0x12E32D0", Offset = "0x12E32D0", VA = "0x7BBBAE32D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9BE")]
			[Address(RVA = "0x12E3088", Offset = "0x12E3088", VA = "0x7BBBAE3088")]
			set
			{
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600E9C0 RID: 59840 RVA: 0x00041CB8 File Offset: 0x0003FEB8
		[Token(Token = "0x17001019")]
		public bool QTu\u0080hBe
		{
			[Token(Token = "0x600E9C0")]
			[Address(RVA = "0x12E32D8", Offset = "0x12E32D8", VA = "0x7BBBAE32D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600E9C1 RID: 59841 RVA: 0x00041CD0 File Offset: 0x0003FED0
		[Token(Token = "0x1700101A")]
		public bool sk[uFqF
		{
			[Token(Token = "0x600E9C1")]
			[Address(RVA = "0x12E3310", Offset = "0x12E3310", VA = "0x7BBBAE3310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x0600E9C2 RID: 59842 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		[Token(Token = "0x1700101B")]
		public bool n^\u0082e~PB
		{
			[Token(Token = "0x600E9C2")]
			[Address(RVA = "0x12E334C", Offset = "0x12E334C", VA = "0x7BBBAE334C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x0600E9C3 RID: 59843 RVA: 0x00041D00 File Offset: 0x0003FF00
		[Token(Token = "0x1700101C")]
		public bool DsFAJDa
		{
			[Token(Token = "0x600E9C3")]
			[Address(RVA = "0x12E33DC", Offset = "0x12E33DC", VA = "0x7BBBAE33DC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E9C4 RID: 59844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E9C4")]
		[Address(RVA = "0x12E33E4", Offset = "0x12E33E4", VA = "0x7BBBAE33E4")]
		public void SetAimRotation(Quaternion laYChSW)
		{
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x0600E9C5 RID: 59845 RVA: 0x00041D18 File Offset: 0x0003FF18
		// (set) Token: 0x0600E9C6 RID: 59846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700101D")]
		public bool QUx{l\u0081y
		{
			[Token(Token = "0x600E9C5")]
			[Address(RVA = "0x12CF028", Offset = "0x12CF028", VA = "0x7BBBACF028")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A460", Offset = "0x114A460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9C6")]
			[Address(RVA = "0x12D1C60", Offset = "0x12D1C60", VA = "0x7BBBAD1C60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A470", Offset = "0x114A470")]
			set
			{
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x0600E9C7 RID: 59847 RVA: 0x00041D30 File Offset: 0x0003FF30
		[Token(Token = "0x1700101E")]
		public aZ hv
		{
			[Token(Token = "0x600E9C7")]
			[Address(RVA = "0x12E3430", Offset = "0x12E3430", VA = "0x7BBBAE3430")]
			get
			{
				return aZ.Invalid;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x00041D48 File Offset: 0x0003FF48
		[Token(Token = "0x1700101F")]
		public uint D[Gv
		{
			[Token(Token = "0x600E9C8")]
			[Address(RVA = "0x12E3438", Offset = "0x12E3438", VA = "0x7BBBAE3438")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x0600E9C9 RID: 59849 RVA: 0x00041D60 File Offset: 0x0003FF60
		[Token(Token = "0x17001020")]
		public byte HHGoU
		{
			[Token(Token = "0x600E9C9")]
			[Address(RVA = "0x12E3440", Offset = "0x12E3440", VA = "0x7BBBAE3440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x00041D78 File Offset: 0x0003FF78
		[Token(Token = "0x17001021")]
		public bool \u007FFXmJKb
		{
			[Token(Token = "0x600E9CA")]
			[Address(RVA = "0x12E3448", Offset = "0x12E3448", VA = "0x7BBBAE3448")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x0600E9CB RID: 59851 RVA: 0x00041D90 File Offset: 0x0003FF90
		[Token(Token = "0x17001022")]
		public bool \u0081\u007FZLbrX
		{
			[Token(Token = "0x600E9CB")]
			[Address(RVA = "0x12E34EC", Offset = "0x12E34EC", VA = "0x7BBBAE34EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		[Token(Token = "0x17001023")]
		public bool QCM}huU
		{
			[Token(Token = "0x600E9CC")]
			[Address(RVA = "0x12E3558", Offset = "0x12E3558", VA = "0x7BBBAE3558")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x0600E9CD RID: 59853 RVA: 0x00041DC0 File Offset: 0x0003FFC0
		[Token(Token = "0x17001024")]
		public bool Knkm\u0081Qy
		{
			[Token(Token = "0x600E9CD")]
			[Address(RVA = "0x12E35C4", Offset = "0x12E35C4", VA = "0x7BBBAE35C4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x0600E9CE RID: 59854 RVA: 0x00041DD8 File Offset: 0x0003FFD8
		[Token(Token = "0x17001025")]
		public bool <<EMPTY_NAME>>
		{
			[Token(Token = "0x600E9CE")]
			[Address(RVA = "0x12E3630", Offset = "0x12E3630", VA = "0x7BBBAE3630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600E9CF RID: 59855 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		[Token(Token = "0x17001026")]
		public bool bmfkWiw
		{
			[Token(Token = "0x600E9CF")]
			[Address(RVA = "0x12E36AC", Offset = "0x12E36AC", VA = "0x7BBBAE36AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x00041E08 File Offset: 0x00040008
		[Token(Token = "0x17001027")]
		public bool vSLAPrC
		{
			[Token(Token = "0x600E9D0")]
			[Address(RVA = "0x12E36C8", Offset = "0x12E36C8", VA = "0x7BBBAE36C8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x0600E9D1 RID: 59857 RVA: 0x00041E20 File Offset: 0x00040020
		[Token(Token = "0x17001028")]
		public bool LQzuz|m
		{
			[Token(Token = "0x600E9D1")]
			[Address(RVA = "0x12E36E4", Offset = "0x12E36E4", VA = "0x7BBBAE36E4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600E9D2 RID: 59858 RVA: 0x00041E38 File Offset: 0x00040038
		[Token(Token = "0x17001029")]
		public bool xe[e[Xz
		{
			[Token(Token = "0x600E9D2")]
			[Address(RVA = "0x12E3700", Offset = "0x12E3700", VA = "0x7BBBAE3700")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x0600E9D3 RID: 59859 RVA: 0x00041E50 File Offset: 0x00040050
		[Token(Token = "0x1700102A")]
		public bool Zxfs\u007FFs
		{
			[Token(Token = "0x600E9D3")]
			[Address(RVA = "0x12E371C", Offset = "0x12E371C", VA = "0x7BBBAE371C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600E9D5 RID: 59861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E9D4 RID: 59860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700102B")]
		public LevelGrapplingHook Z]y\u0082HXR
		{
			[Token(Token = "0x600E9D5")]
			[Address(RVA = "0x12E3740", Offset = "0x12E3740", VA = "0x7BBBAE3740")]
			get
			{
				return null;
			}
			[Token(Token = "0x600E9D4")]
			[Address(RVA = "0x12E3738", Offset = "0x12E3738", VA = "0x7BBBAE3738")]
			set
			{
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600E9D6 RID: 59862 RVA: 0x00041E68 File Offset: 0x00040068
		[Token(Token = "0x1700102C")]
		public bool EZ^\u0081wnQ
		{
			[Token(Token = "0x600E9D6")]
			[Address(RVA = "0x12E3748", Offset = "0x12E3748", VA = "0x7BBBAE3748")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600E9D7 RID: 59863 RVA: 0x00041E80 File Offset: 0x00040080
		// (set) Token: 0x0600E9D8 RID: 59864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700102D")]
		public bool ~{jkkP
		{
			[Token(Token = "0x600E9D7")]
			[Address(RVA = "0x12E3784", Offset = "0x12E3784", VA = "0x7BBBAE3784")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A480", Offset = "0x114A480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9D8")]
			[Address(RVA = "0x12E378C", Offset = "0x12E378C", VA = "0x7BBBAE378C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A490", Offset = "0x114A490")]
			protected set
			{
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x0600E9D9 RID: 59865 RVA: 0x00041E98 File Offset: 0x00040098
		// (set) Token: 0x0600E9DA RID: 59866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700102E")]
		public int \u0082dMDWRN
		{
			[Token(Token = "0x600E9D9")]
			[Address(RVA = "0x12E3798", Offset = "0x12E3798", VA = "0x7BBBAE3798")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A4A0", Offset = "0x114A4A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600E9DA")]
			[Address(RVA = "0x12E37A0", Offset = "0x12E37A0", VA = "0x7BBBAE37A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A4B0", Offset = "0x114A4B0")]
			protected set
			{
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x00041EB0 File Offset: 0x000400B0
		// (set) Token: 0x0600E9DC RID: 59868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700102F")]
		public bool FSWq{vO
		{
			[Token(Token = "0x600E9DB")]
			[Address(RVA = "0x12E37A8", Offset = "0x12E37A8", VA = "0x7BBBAE37A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A4C0", Offset = "0x114A4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9DC")]
			[Address(RVA = "0x12E37B0", Offset = "0x12E37B0", VA = "0x7BBBAE37B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A4D0", Offset = "0x114A4D0")]
			set
			{
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x0600E9DD RID: 59869 RVA: 0x00041EC8 File Offset: 0x000400C8
		// (set) Token: 0x0600E9DE RID: 59870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001030")]
		public bool b
		{
			[Token(Token = "0x600E9DD")]
			[Address(RVA = "0x12D6570", Offset = "0x12D6570", VA = "0x7BBBAD6570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A4E0", Offset = "0x114A4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9DE")]
			[Address(RVA = "0x12E37BC", Offset = "0x12E37BC", VA = "0x7BBBAE37BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A4F0", Offset = "0x114A4F0")]
			set
			{
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x0600E9DF RID: 59871 RVA: 0x00041EE0 File Offset: 0x000400E0
		[Token(Token = "0x17001031")]
		public bool m\u0082]hlUf
		{
			[Token(Token = "0x600E9DF")]
			[Address(RVA = "0x12E37C8", Offset = "0x12E37C8", VA = "0x7BBBAE37C8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x0600E9E0 RID: 59872 RVA: 0x00041EF8 File Offset: 0x000400F8
		[Token(Token = "0x17001032")]
		public bool <<EMPTY_NAME>>
		{
			[Token(Token = "0x600E9E0")]
			[Address(RVA = "0x12E37F8", Offset = "0x12E37F8", VA = "0x7BBBAE37F8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600E9E1 RID: 59873 RVA: 0x00041F10 File Offset: 0x00040110
		// (set) Token: 0x0600E9E2 RID: 59874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001033")]
		public bool CGP{VlW
		{
			[Token(Token = "0x600E9E1")]
			[Address(RVA = "0x12E3828", Offset = "0x12E3828", VA = "0x7BBBAE3828")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A500", Offset = "0x114A500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9E2")]
			[Address(RVA = "0x12E3830", Offset = "0x12E3830", VA = "0x7BBBAE3830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A510", Offset = "0x114A510")]
			set
			{
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600E9E3 RID: 59875 RVA: 0x00041F28 File Offset: 0x00040128
		[Token(Token = "0x17001034")]
		public bool YJabSRy
		{
			[Token(Token = "0x600E9E3")]
			[Address(RVA = "0x12CFB94", Offset = "0x12CFB94", VA = "0x7BBBACFB94")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x0600E9E4 RID: 59876 RVA: 0x00041F40 File Offset: 0x00040140
		[Token(Token = "0x17001035")]
		public bool \u0080hLXU{a
		{
			[Token(Token = "0x600E9E4")]
			[Address(RVA = "0x12E383C", Offset = "0x12E383C", VA = "0x7BBBAE383C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x0600E9E5 RID: 59877 RVA: 0x00041F58 File Offset: 0x00040158
		// (set) Token: 0x0600E9E6 RID: 59878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001036")]
		public bool sF|AVAC
		{
			[Token(Token = "0x600E9E5")]
			[Address(RVA = "0x12E3948", Offset = "0x12E3948", VA = "0x7BBBAE3948")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A520", Offset = "0x114A520")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9E6")]
			[Address(RVA = "0x12E3950", Offset = "0x12E3950", VA = "0x7BBBAE3950")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A530", Offset = "0x114A530")]
			set
			{
			}
		}

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9E7")]
		[Address(RVA = "0x12E395C", Offset = "0x12E395C", VA = "0x7BBBAE395C", Slot = "64")]
		public Vehicle VehicleIAmIn()
		{
			return null;
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x00041F70 File Offset: 0x00040170
		[Token(Token = "0x600E9E8")]
		[Address(RVA = "0x12E3964", Offset = "0x12E3964", VA = "0x7BBBAE3964")]
		public bool IsInVehicleCanFire()
		{
			return default(bool);
		}

		// Token: 0x0600E9E9 RID: 59881 RVA: 0x00041F88 File Offset: 0x00040188
		[Token(Token = "0x600E9E9")]
		[Address(RVA = "0x12E3A60", Offset = "0x12E3A60", VA = "0x7BBBAE3A60", Slot = "65")]
		public bool IsPassengerInVehicleCanFire()
		{
			return default(bool);
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x0600E9EA RID: 59882 RVA: 0x00041FA0 File Offset: 0x000401A0
		// (set) Token: 0x0600E9EB RID: 59883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001037")]
		public bool kkDdeKn
		{
			[Token(Token = "0x600E9EA")]
			[Address(RVA = "0x12E3BE8", Offset = "0x12E3BE8", VA = "0x7BBBAE3BE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9EB")]
			[Address(RVA = "0x12E3BF0", Offset = "0x12E3BF0", VA = "0x7BBBAE3BF0")]
			set
			{
			}
		}

		// Token: 0x0600E9EC RID: 59884 RVA: 0x00041FB8 File Offset: 0x000401B8
		[Token(Token = "0x600E9EC")]
		[Address(RVA = "0x12E3BFC", Offset = "0x12E3BFC", VA = "0x7BBBAE3BFC")]
		public bool IsDriverInVehicleCanFire()
		{
			return default(bool);
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x0600E9ED RID: 59885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001038")]
		public LevelChair OamqPlk
		{
			[Token(Token = "0x600E9ED")]
			[Address(RVA = "0x12C8C94", Offset = "0x12C8C94", VA = "0x7BBBAC8C94")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E9EE RID: 59886 RVA: 0x00041FD0 File Offset: 0x000401D0
		[Token(Token = "0x600E9EE")]
		[Address(RVA = "0x12CEFC0", Offset = "0x12CEFC0", VA = "0x7BBBACEFC0", Slot = "68")]
		public bool IsInCatapult()
		{
			return default(bool);
		}

		// Token: 0x0600E9EF RID: 59887 RVA: 0x00041FE8 File Offset: 0x000401E8
		[Token(Token = "0x600E9EF")]
		[Address(RVA = "0x12E3D60", Offset = "0x12E3D60", VA = "0x7BBBAE3D60")]
		public bool IsUseSpaceShield()
		{
			return default(bool);
		}

		// Token: 0x0600E9F0 RID: 59888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E9F0")]
		[Address(RVA = "0x12E3F6C", Offset = "0x12E3F6C", VA = "0x7BBBAE3F6C")]
		public LevelCatapult GetCatapultIAmIn()
		{
			return null;
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x00042000 File Offset: 0x00040200
		[Token(Token = "0x17001039")]
		public int RbhIP\u0081E
		{
			[Token(Token = "0x600E9F1")]
			[Address(RVA = "0x12CE048", Offset = "0x12CE048", VA = "0x7BBBACE048")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x0600E9F2 RID: 59890 RVA: 0x00042018 File Offset: 0x00040218
		[Token(Token = "0x1700103A")]
		public bool CzejAg\u007F
		{
			[Token(Token = "0x600E9F2")]
			[Address(RVA = "0x12D1984", Offset = "0x12D1984", VA = "0x7BBBAD1984")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600E9F3 RID: 59891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103B")]
		public Transform jJHVtj|
		{
			[Token(Token = "0x600E9F3")]
			[Address(RVA = "0x12E3F74", Offset = "0x12E3F74", VA = "0x7BBBAE3F74")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x0600E9F4 RID: 59892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103C")]
		public Transform Ziz\u007FZiJ
		{
			[Token(Token = "0x600E9F4")]
			[Address(RVA = "0x12E4010", Offset = "0x12E4010", VA = "0x7BBBAE4010")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x0600E9F5 RID: 59893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103D")]
		public Transform A\u0082
		{
			[Token(Token = "0x600E9F5")]
			[Address(RVA = "0x12E40AC", Offset = "0x12E40AC", VA = "0x7BBBAE40AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x0600E9F6 RID: 59894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103E")]
		protected Transform ~QYc]d\u007F
		{
			[Token(Token = "0x600E9F6")]
			[Address(RVA = "0x12E4148", Offset = "0x12E4148", VA = "0x7BBBAE4148")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x00042030 File Offset: 0x00040230
		[Token(Token = "0x1700103F")]
		public bool CRveKtI
		{
			[Token(Token = "0x600E9F7")]
			[Address(RVA = "0x12D19C0", Offset = "0x12D19C0", VA = "0x7BBBAD19C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x0600E9F8 RID: 59896 RVA: 0x00042048 File Offset: 0x00040248
		[Token(Token = "0x17001040")]
		public bool }\u0080aKtng
		{
			[Token(Token = "0x600E9F8")]
			[Address(RVA = "0x12E41E4", Offset = "0x12E41E4", VA = "0x7BBBAE41E4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x0600E9F9 RID: 59897 RVA: 0x00042060 File Offset: 0x00040260
		[Token(Token = "0x17001041")]
		public bool OBZnwas
		{
			[Token(Token = "0x600E9F9")]
			[Address(RVA = "0x12E4220", Offset = "0x12E4220", VA = "0x7BBBAE4220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x0600E9FA RID: 59898 RVA: 0x00042078 File Offset: 0x00040278
		[Token(Token = "0x17001042")]
		public bool SiR]NLW
		{
			[Token(Token = "0x600E9FA")]
			[Address(RVA = "0x12E42EC", Offset = "0x12E42EC", VA = "0x7BBBAE42EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600E9FB RID: 59899 RVA: 0x00042090 File Offset: 0x00040290
		[Token(Token = "0x17001043")]
		public bool UbkzZh^
		{
			[Token(Token = "0x600E9FB")]
			[Address(RVA = "0x12CEEB0", Offset = "0x12CEEB0", VA = "0x7BBBACEEB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600E9FC RID: 59900 RVA: 0x000420A8 File Offset: 0x000402A8
		[Token(Token = "0x17001044")]
		public bool LaBjxmz
		{
			[Token(Token = "0x600E9FC")]
			[Address(RVA = "0x12E4328", Offset = "0x12E4328", VA = "0x7BBBAE4328")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x000420C0 File Offset: 0x000402C0
		[Token(Token = "0x17001045")]
		public bool X^xnUNf
		{
			[Token(Token = "0x600E9FD")]
			[Address(RVA = "0x12CEEE0", Offset = "0x12CEEE0", VA = "0x7BBBACEEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x0600E9FE RID: 59902 RVA: 0x000420D8 File Offset: 0x000402D8
		// (set) Token: 0x0600E9FF RID: 59903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001046")]
		public bool ooeMXUA
		{
			[Token(Token = "0x600E9FE")]
			[Address(RVA = "0x12E4358", Offset = "0x12E4358", VA = "0x7BBBAE4358")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E9FF")]
			[Address(RVA = "0x12E4360", Offset = "0x12E4360", VA = "0x7BBBAE4360")]
			set
			{
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x0600EA00 RID: 59904 RVA: 0x000420F0 File Offset: 0x000402F0
		[Token(Token = "0x17001047")]
		public bool ]Zlp
		{
			[Token(Token = "0x600EA00")]
			[Address(RVA = "0x12E436C", Offset = "0x12E436C", VA = "0x7BBBAE436C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x0600EA01 RID: 59905 RVA: 0x00042108 File Offset: 0x00040308
		// (set) Token: 0x0600EA02 RID: 59906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001048")]
		public bool zZB{Qb^
		{
			[Token(Token = "0x600EA01")]
			[Address(RVA = "0x12E43B8", Offset = "0x12E43B8", VA = "0x7BBBAE43B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A540", Offset = "0x114A540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EA02")]
			[Address(RVA = "0x12E43C0", Offset = "0x12E43C0", VA = "0x7BBBAE43C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A550", Offset = "0x114A550")]
			set
			{
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x00042120 File Offset: 0x00040320
		[Token(Token = "0x17001049")]
		public bool C
		{
			[Token(Token = "0x600EA03")]
			[Address(RVA = "0x12E43CC", Offset = "0x12E43CC", VA = "0x7BBBAE43CC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600EA04 RID: 59908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700104A")]
		public r^RKaYZ EK^\u0080
		{
			[Token(Token = "0x600EA04")]
			[Address(RVA = "0x12E43D4", Offset = "0x12E43D4", VA = "0x7BBBAE43D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700104B")]
		public List<ZjcDgQ\u007F> oPZ\u0080H\u0081Y
		{
			[Token(Token = "0x600EA05")]
			[Address(RVA = "0x12E43DC", Offset = "0x12E43DC", VA = "0x7BBBAE43DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600EA06 RID: 59910 RVA: 0x00042138 File Offset: 0x00040338
		// (set) Token: 0x0600EA07 RID: 59911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700104C")]
		public bool ljGtBp^
		{
			[Token(Token = "0x600EA06")]
			[Address(RVA = "0x12E43E4", Offset = "0x12E43E4", VA = "0x7BBBAE43E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EA07")]
			[Address(RVA = "0x12E43EC", Offset = "0x12E43EC", VA = "0x7BBBAE43EC")]
			set
			{
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600EA08 RID: 59912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700104D")]
		public LevelTriggerHumanTire rbxyp{O
		{
			[Token(Token = "0x600EA08")]
			[Address(RVA = "0x12E43F8", Offset = "0x12E43F8", VA = "0x7BBBAE43F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EA09 RID: 59913 RVA: 0x00042150 File Offset: 0x00040350
		[Token(Token = "0x600EA09")]
		[Address(RVA = "0x12E4488", Offset = "0x12E4488", VA = "0x7BBBAE4488")]
		public bool CanHumanTireJump()
		{
			return default(bool);
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600EA0A RID: 59914 RVA: 0x00042168 File Offset: 0x00040368
		// (set) Token: 0x0600EA0B RID: 59915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700104E")]
		public Player.WJA\u0080Xxv QCHo\u0081}R
		{
			[Token(Token = "0x600EA0A")]
			[Address(RVA = "0x12E496C", Offset = "0x12E496C", VA = "0x7BBBAE496C")]
			get
			{
				return Player.WJA\u0080Xxv.NONE;
			}
			[Token(Token = "0x600EA0B")]
			[Address(RVA = "0x12E4974", Offset = "0x12E4974", VA = "0x7BBBAE4974")]
			set
			{
			}
		}

		// Token: 0x0600EA0C RID: 59916 RVA: 0x00042180 File Offset: 0x00040380
		[Token(Token = "0x600EA0C")]
		[Address(RVA = "0x12E497C", Offset = "0x12E497C", VA = "0x7BBBAE497C", Slot = "50")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x0600EA0D RID: 59917 RVA: 0x00042198 File Offset: 0x00040398
		[Token(Token = "0x600EA0D")]
		[Address(RVA = "0x12E4988", Offset = "0x12E4988", VA = "0x7BBBAE4988", Slot = "51")]
		public override bool IsStreamerVisible()
		{
			return default(bool);
		}

		// Token: 0x0600EA0E RID: 59918 RVA: 0x000421B0 File Offset: 0x000403B0
		[Token(Token = "0x600EA0E")]
		[Address(RVA = "0x12E4A10", Offset = "0x12E4A10", VA = "0x7BBBAE4A10")]
		public bool IsPartialVisible(uint UOhq{XI)
		{
			return default(bool);
		}

		// Token: 0x0600EA0F RID: 59919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA0F")]
		[Address(RVA = "0x12E4A48", Offset = "0x12E4A48", VA = "0x7BBBAE4A48", Slot = "88")]
		public virtual BaseProfileInfo PlayerBaseProfile()
		{
			return null;
		}

		// Token: 0x0600EA10 RID: 59920 RVA: 0x000421C8 File Offset: 0x000403C8
		[Token(Token = "0x600EA10")]
		[Address(RVA = "0x12E4A50", Offset = "0x12E4A50", VA = "0x7BBBAE4A50", Slot = "89")]
		public virtual bool IsWatching()
		{
			return default(bool);
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600EA12 RID: 59922 RVA: 0x000421E0 File Offset: 0x000403E0
		// (set) Token: 0x0600EA11 RID: 59921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700104F")]
		public uint [^iWgHY
		{
			[Token(Token = "0x600EA12")]
			[Address(RVA = "0x12E4A60", Offset = "0x12E4A60", VA = "0x7BBBAE4A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A570", Offset = "0x114A570")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600EA11")]
			[Address(RVA = "0x12E4A58", Offset = "0x12E4A58", VA = "0x7BBBAE4A58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A560", Offset = "0x114A560")]
			protected set
			{
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x0600EA13 RID: 59923 RVA: 0x000421F8 File Offset: 0x000403F8
		// (set) Token: 0x0600EA14 RID: 59924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001050")]
		public float D]NorJx
		{
			[Token(Token = "0x600EA13")]
			[Address(RVA = "0x12E4A68", Offset = "0x12E4A68", VA = "0x7BBBAE4A68")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600EA14")]
			[Address(RVA = "0x12E4A70", Offset = "0x12E4A70", VA = "0x7BBBAE4A70")]
			set
			{
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600EA15 RID: 59925 RVA: 0x00042210 File Offset: 0x00040410
		// (set) Token: 0x0600EA16 RID: 59926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001051")]
		public float uHpe\u0081\u0082f
		{
			[Token(Token = "0x600EA15")]
			[Address(RVA = "0x12E4A78", Offset = "0x12E4A78", VA = "0x7BBBAE4A78")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600EA16")]
			[Address(RVA = "0x12E4A80", Offset = "0x12E4A80", VA = "0x7BBBAE4A80")]
			set
			{
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x0600EA17 RID: 59927 RVA: 0x00042228 File Offset: 0x00040428
		[Token(Token = "0x17001052")]
		public bool KSWfgDz
		{
			[Token(Token = "0x600EA17")]
			[Address(RVA = "0x12E4A88", Offset = "0x12E4A88", VA = "0x7BBBAE4A88")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x0600EA18 RID: 59928 RVA: 0x00042240 File Offset: 0x00040440
		// (set) Token: 0x0600EA19 RID: 59929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001053")]
		public bool N|vj
		{
			[Token(Token = "0x600EA18")]
			[Address(RVA = "0x12E4A90", Offset = "0x12E4A90", VA = "0x7BBBAE4A90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EA19")]
			[Address(RVA = "0x12E4A98", Offset = "0x12E4A98", VA = "0x7BBBAE4A98")]
			set
			{
			}
		}

		// Token: 0x0600EA1A RID: 59930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA1A")]
		public static Player CreatePlayer<T>(Transform i~Bf~sj, ulong z^hr]Er, ulong aj[QH\u0080w, {QAb\u0082~u BhUcw{z, bool Z~RaYh~ = false, [Optional] object ldzAD`u) where T : Player
		{
			return null;
		}

		// Token: 0x0600EA1B RID: 59931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA1B")]
		[Address(RVA = "0x12E4AA4", Offset = "0x12E4AA4", VA = "0x7BBBAE4AA4")]
		public static Player_TrainingHumanTarget CreateHumanTargetPlayer(Transform yh\u007FjWGw, {QAb\u0082~u AMKDtaL)
		{
			return null;
		}

		// Token: 0x0600EA1C RID: 59932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1C")]
		[Address(RVA = "0x12E4D80", Offset = "0x12E4D80", VA = "0x7BBBAE4D80")]
		public void CreateCapsuleHuman()
		{
		}

		// Token: 0x0600EA1D RID: 59933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1D")]
		[Address(RVA = "0x12E4EC8", Offset = "0x12E4EC8", VA = "0x7BBBAE4EC8", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600EA1E RID: 59934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA1E")]
		[Address(RVA = "0x12E5804", Offset = "0x12E5804", VA = "0x7BBBAE5804")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114A580", Offset = "0x114A580")]
		protected IEnumerator Mxs]Emc()
		{
			return null;
		}

		// Token: 0x0600EA1F RID: 59935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA1F")]
		[Address(RVA = "0x12E5878", Offset = "0x12E5878", VA = "0x7BBBAE5878", Slot = "90")]
		public virtual void InitWhenAvatarReady()
		{
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600EA20 RID: 59936 RVA: 0x00042258 File Offset: 0x00040458
		// (set) Token: 0x0600EA21 RID: 59937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001054")]
		public bool |xsM\u0080\u0080R
		{
			[Token(Token = "0x600EA20")]
			[Address(RVA = "0x12C8C9C", Offset = "0x12C8C9C", VA = "0x7BBBAC8C9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A5E4", Offset = "0x114A5E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EA21")]
			[Address(RVA = "0x12E4D74", Offset = "0x12E4D74", VA = "0x7BBBAE4D74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A5F4", Offset = "0x114A5F4")]
			protected set
			{
			}
		}

		// Token: 0x0600EA22 RID: 59938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA22")]
		[Address(RVA = "0x12E59A0", Offset = "0x12E59A0", VA = "0x7BBBAE59A0")]
		public void EnableCharactorController(uint UOhq{XI, bool wLdlWCv)
		{
		}

		// Token: 0x0600EA23 RID: 59939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA23")]
		[Address(RVA = "0x12E5AEC", Offset = "0x12E5AEC", VA = "0x7BBBAE5AEC")]
		public void SetVisibleOnTrainingZoneChange(bool FexeocR)
		{
		}

		// Token: 0x0600EA24 RID: 59940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA24")]
		[Address(RVA = "0x12E5AD8", Offset = "0x12E5AD8", VA = "0x7BBBAE5AD8")]
		private void XwFd^Kj(bool wqTuwxJ)
		{
		}

		// Token: 0x0600EA25 RID: 59941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA25")]
		[Address(RVA = "0x12E5B30", Offset = "0x12E5B30", VA = "0x7BBBAE5B30", Slot = "91")]
		public virtual void SetVisible(uint UOhq{XI, bool wLdlWCv)
		{
		}

		// Token: 0x0600EA26 RID: 59942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA26")]
		[Address(RVA = "0x12E6EC8", Offset = "0x12E6EC8", VA = "0x7BBBAE6EC8")]
		public void RefreshVehicleAnim()
		{
		}

		// Token: 0x0600EA27 RID: 59943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA27")]
		[Address(RVA = "0x12E6FCC", Offset = "0x12E6FCC", VA = "0x7BBBAE6FCC", Slot = "92")]
		protected virtual void U\u0081m}kyZ()
		{
		}

		// Token: 0x0600EA28 RID: 59944 RVA: 0x00042270 File Offset: 0x00040470
		[Token(Token = "0x600EA28")]
		[Address(RVA = "0x12E6FD0", Offset = "0x12E6FD0", VA = "0x7BBBAE6FD0")]
		private bool rsy\u0080j]x()
		{
			return default(bool);
		}

		// Token: 0x0600EA29 RID: 59945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA29")]
		[Address(RVA = "0x12DFC74", Offset = "0x12DFC74", VA = "0x7BBBADFC74")]
		public \u0080uwjcYk GetInventoryManager()
		{
			return null;
		}

		// Token: 0x0600EA2A RID: 59946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA2A")]
		[Address(RVA = "0x12CCBB0", Offset = "0x12CCBB0", VA = "0x7BBBACCBB0")]
		public ytMNhlw GetWeaponOnHand()
		{
			return null;
		}

		// Token: 0x0600EA2B RID: 59947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA2B")]
		[Address(RVA = "0x12E7020", Offset = "0x12E7020", VA = "0x7BBBAE7020")]
		public ytMNhlw GetActiveWeapon()
		{
			return null;
		}

		// Token: 0x0600EA2C RID: 59948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA2C")]
		[Address(RVA = "0x12E7060", Offset = "0x12E7060", VA = "0x7BBBAE7060", Slot = "11")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600EA2D RID: 59949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA2D")]
		[Address(RVA = "0x12E708C", Offset = "0x12E708C", VA = "0x7BBBAE708C")]
		protected void ~k\u0081xq[\u0082()
		{
		}

		// Token: 0x0600EA2E RID: 59950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA2E")]
		[Address(RVA = "0x12E7278", Offset = "0x12E7278", VA = "0x7BBBAE7278")]
		private void vrBYWni(Transform oN\u0081sXm[, Transform VT`lIxO)
		{
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600EA2F RID: 59951 RVA: 0x00042288 File Offset: 0x00040488
		// (set) Token: 0x0600EA30 RID: 59952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001055")]
		public ResourceID CEDvkeu
		{
			[Token(Token = "0x600EA2F")]
			[Address(RVA = "0x12E791C", Offset = "0x12E791C", VA = "0x7BBBAE791C")]
			get
			{
				return default(ResourceID);
			}
			[Token(Token = "0x600EA30")]
			[Address(RVA = "0x12E7924", Offset = "0x12E7924", VA = "0x7BBBAE7924")]
			set
			{
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x0600EA31 RID: 59953 RVA: 0x000422A0 File Offset: 0x000404A0
		// (set) Token: 0x0600EA32 RID: 59954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001056")]
		public ResourceID gB
		{
			[Token(Token = "0x600EA31")]
			[Address(RVA = "0x12E792C", Offset = "0x12E792C", VA = "0x7BBBAE792C")]
			get
			{
				return default(ResourceID);
			}
			[Token(Token = "0x600EA32")]
			[Address(RVA = "0x12E7934", Offset = "0x12E7934", VA = "0x7BBBAE7934")]
			set
			{
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x0600EA33 RID: 59955 RVA: 0x000422B8 File Offset: 0x000404B8
		// (set) Token: 0x0600EA34 RID: 59956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001057")]
		public ResourceID \u007FL\u007FzSxz
		{
			[Token(Token = "0x600EA33")]
			[Address(RVA = "0x12E793C", Offset = "0x12E793C", VA = "0x7BBBAE793C")]
			get
			{
				return default(ResourceID);
			}
			[Token(Token = "0x600EA34")]
			[Address(RVA = "0x12E7944", Offset = "0x12E7944", VA = "0x7BBBAE7944")]
			set
			{
			}
		}

		// Token: 0x0600EA35 RID: 59957 RVA: 0x000422D0 File Offset: 0x000404D0
		[Token(Token = "0x600EA35")]
		[Address(RVA = "0x12E794C", Offset = "0x12E794C", VA = "0x7BBBAE794C", Slot = "93")]
		public virtual bool HaveFlight()
		{
			return default(bool);
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x0600EA36 RID: 59958 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EA37 RID: 59959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001058")]
		public SkyboardData \u0082mHCu[O
		{
			[Token(Token = "0x600EA36")]
			[Address(RVA = "0x12E7954", Offset = "0x12E7954", VA = "0x7BBBAE7954")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EA37")]
			[Address(RVA = "0x12E795C", Offset = "0x12E795C", VA = "0x7BBBAE795C")]
			set
			{
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x0600EA38 RID: 59960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001059")]
		public PlayerAudioComponent MUGVe\u0082i
		{
			[Token(Token = "0x600EA38")]
			[Address(RVA = "0x12E7964", Offset = "0x12E7964", VA = "0x7BBBAE7964")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105A")]
		public Parachute ey}
		{
			[Token(Token = "0x600EA39")]
			[Address(RVA = "0x12E7A14", Offset = "0x12E7A14", VA = "0x7BBBAE7A14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EA3A RID: 59962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA3A")]
		[Address(RVA = "0x12E7A1C", Offset = "0x12E7A1C", VA = "0x7BBBAE7A1C")]
		protected Transform sEJAdWH()
		{
			return null;
		}

		// Token: 0x0600EA3B RID: 59963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA3B")]
		[Address(RVA = "0x12E7B84", Offset = "0x12E7B84", VA = "0x7BBBAE7B84", Slot = "94")]
		public virtual void InitProperties(object mS{yct~, bool H~lDHCI = true)
		{
		}

		// Token: 0x0600EA3C RID: 59964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA3C")]
		[Address(RVA = "0x12E8378", Offset = "0x12E8378", VA = "0x7BBBAE8378")]
		protected void fsva{Q|(Player.Nn yfq{tix)
		{
		}

		// Token: 0x0600EA3D RID: 59965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA3D")]
		[Address(RVA = "0x12E81DC", Offset = "0x12E81DC", VA = "0x7BBBAE81DC")]
		protected void zMnWRcy()
		{
		}

		// Token: 0x0600EA3E RID: 59966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA3E")]
		[Address(RVA = "0x12E8380", Offset = "0x12E8380", VA = "0x7BBBAE8380", Slot = "95")]
		protected virtual void v~u|lmI()
		{
		}

		// Token: 0x0600EA3F RID: 59967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA3F")]
		[Address(RVA = "0x12E9938", Offset = "0x12E9938", VA = "0x7BBBAE9938", Slot = "96")]
		public virtual void UpdateShiledEffect()
		{
		}

		// Token: 0x0600EA40 RID: 59968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA40")]
		[Address(RVA = "0x12E9CBC", Offset = "0x12E9CBC", VA = "0x7BBBAE9CBC")]
		public void ShowShieldAttackedEffect(Player SwdqkVR)
		{
		}

		// Token: 0x0600EA41 RID: 59969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA41")]
		[Address(RVA = "0x12E9910", Offset = "0x12E9910", VA = "0x7BBBAE9910")]
		private void eYOcBEk()
		{
		}

		// Token: 0x0600EA42 RID: 59970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA42")]
		[Address(RVA = "0x12E9608", Offset = "0x12E9608", VA = "0x7BBBAE9608")]
		protected void dYTitUd()
		{
		}

		// Token: 0x0600EA43 RID: 59971 RVA: 0x000422E8 File Offset: 0x000404E8
		[Token(Token = "0x600EA43")]
		[Address(RVA = "0x12E9DD0", Offset = "0x12E9DD0", VA = "0x7BBBAE9DD0")]
		public static bool IsLocalPlayer(ulong z^hr]Er, {QAb\u0082~u BhUcw{z)
		{
			return default(bool);
		}

		// Token: 0x0600EA44 RID: 59972 RVA: 0x00042300 File Offset: 0x00040500
		[Token(Token = "0x600EA44")]
		[Address(RVA = "0x12C8480", Offset = "0x12C8480", VA = "0x7BBBAC8480")]
		public bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600EA45 RID: 59973 RVA: 0x00042318 File Offset: 0x00040518
		[Token(Token = "0x600EA45")]
		[Address(RVA = "0x12E9EA8", Offset = "0x12E9EA8", VA = "0x7BBBAE9EA8", Slot = "97")]
		public virtual bool IsLocalTeammate()
		{
			return default(bool);
		}

		// Token: 0x0600EA46 RID: 59974 RVA: 0x00042330 File Offset: 0x00040530
		[Token(Token = "0x600EA46")]
		[Address(RVA = "0x12E9F7C", Offset = "0x12E9F7C", VA = "0x7BBBAE9F7C")]
		public bool IsInLocalPlayerServiceGroup()
		{
			return default(bool);
		}

		// Token: 0x0600EA47 RID: 59975 RVA: 0x00042348 File Offset: 0x00040548
		[Token(Token = "0x600EA47")]
		[Address(RVA = "0x12EA048", Offset = "0x12EA048", VA = "0x7BBBAEA048")]
		public bool ShowWeaponSkin()
		{
			return default(bool);
		}

		// Token: 0x0600EA48 RID: 59976 RVA: 0x00042360 File Offset: 0x00040560
		[Token(Token = "0x600EA48")]
		[Address(RVA = "0x12EA0EC", Offset = "0x12EA0EC", VA = "0x7BBBAEA0EC")]
		public bool ShowSkin()
		{
			return default(bool);
		}

		// Token: 0x0600EA49 RID: 59977 RVA: 0x00042378 File Offset: 0x00040578
		[Token(Token = "0x600EA49")]
		[Address(RVA = "0x12EA2C4", Offset = "0x12EA2C4", VA = "0x7BBBAEA2C4")]
		public static bool ShowSkinForQualityAndMemory()
		{
			return default(bool);
		}

		// Token: 0x0600EA4A RID: 59978 RVA: 0x00042390 File Offset: 0x00040590
		[Token(Token = "0x600EA4A")]
		[Address(RVA = "0x12EA3D8", Offset = "0x12EA3D8", VA = "0x7BBBAEA3D8")]
		public bool ShowFistWeapon()
		{
			return default(bool);
		}

		// Token: 0x0600EA4B RID: 59979 RVA: 0x000423A8 File Offset: 0x000405A8
		[Token(Token = "0x600EA4B")]
		[Address(RVA = "0x12EA4BC", Offset = "0x12EA4BC", VA = "0x7BBBAEA4BC")]
		public bool ShowHandWeaponEffect()
		{
			return default(bool);
		}

		// Token: 0x0600EA4C RID: 59980 RVA: 0x000423C0 File Offset: 0x000405C0
		[Token(Token = "0x600EA4C")]
		[Address(RVA = "0x12EA5D4", Offset = "0x12EA5D4", VA = "0x7BBBAEA5D4")]
		public bool ShowHandWeaponFireEffect()
		{
			return default(bool);
		}

		// Token: 0x0600EA4D RID: 59981 RVA: 0x000423D8 File Offset: 0x000405D8
		[Token(Token = "0x600EA4D")]
		[Address(RVA = "0x12EA6E8", Offset = "0x12EA6E8", VA = "0x7BBBAEA6E8")]
		public bool ShowHandWeaponGunTraceEffect()
		{
			return default(bool);
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x000423F0 File Offset: 0x000405F0
		[Token(Token = "0x600EA4E")]
		[Address(RVA = "0x12EA7DC", Offset = "0x12EA7DC", VA = "0x7BBBAEA7DC")]
		public bool ShowBackWeaponEffect()
		{
			return default(bool);
		}

		// Token: 0x0600EA4F RID: 59983 RVA: 0x00042408 File Offset: 0x00040608
		[Token(Token = "0x600EA4F")]
		[Address(RVA = "0x12EA8F4", Offset = "0x12EA8F4", VA = "0x7BBBAEA8F4")]
		public bool ShowClothEffect()
		{
			return default(bool);
		}

		// Token: 0x0600EA50 RID: 59984 RVA: 0x00042420 File Offset: 0x00040620
		[Token(Token = "0x600EA50")]
		[Address(RVA = "0x12EAA24", Offset = "0x12EAA24", VA = "0x7BBBAEAA24")]
		public static bool UseHighQualityAvatar(ulong z^hr]Er, {QAb\u0082~u BhUcw{z, ulong aj[QH\u0080w)
		{
			return default(bool);
		}

		// Token: 0x0600EA51 RID: 59985 RVA: 0x00042438 File Offset: 0x00040638
		[Token(Token = "0x600EA51")]
		[Address(RVA = "0x12EADA8", Offset = "0x12EADA8", VA = "0x7BBBAEADA8")]
		public bool UseHighQualityAvatar()
		{
			return default(bool);
		}

		// Token: 0x0600EA52 RID: 59986 RVA: 0x00042450 File Offset: 0x00040650
		[Token(Token = "0x600EA52")]
		[Address(RVA = "0x12C851C", Offset = "0x12C851C", VA = "0x7BBBAC851C")]
		public bool IsLocalObservered()
		{
			return default(bool);
		}

		// Token: 0x0600EA53 RID: 59987 RVA: 0x00042468 File Offset: 0x00040668
		[Token(Token = "0x600EA53")]
		[Address(RVA = "0x12EAE4C", Offset = "0x12EAE4C", VA = "0x7BBBAEAE4C")]
		public bool IsLocalTryingObservered()
		{
			return default(bool);
		}

		// Token: 0x0600EA54 RID: 59988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA54")]
		[Address(RVA = "0x12EAF98", Offset = "0x12EAF98", VA = "0x7BBBAEAF98", Slot = "98")]
		public virtual void SetAI(bool K`OU\u0080vI)
		{
		}

		// Token: 0x0600EA55 RID: 59989 RVA: 0x00042480 File Offset: 0x00040680
		[Token(Token = "0x600EA55")]
		[Address(RVA = "0x12EB14C", Offset = "0x12EB14C", VA = "0x7BBBAEB14C")]
		public bool IsUserControlChanged()
		{
			return default(bool);
		}

		// Token: 0x0600EA56 RID: 59990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA56")]
		[Address(RVA = "0x12EB18C", Offset = "0x12EB18C", VA = "0x7BBBAEB18C", Slot = "61")]
		public GameObject GetGameObject()
		{
			return null;
		}

		// Token: 0x0600EA57 RID: 59991 RVA: 0x00042498 File Offset: 0x00040698
		[Token(Token = "0x600EA57")]
		[Address(RVA = "0x12EB194", Offset = "0x12EB194", VA = "0x7BBBAEB194")]
		public Vector3 GetTargetDirection()
		{
			return default(Vector3);
		}

		// Token: 0x0600EA58 RID: 59992 RVA: 0x000424B0 File Offset: 0x000406B0
		[Token(Token = "0x600EA58")]
		[Address(RVA = "0x12EB1C4", Offset = "0x12EB1C4", VA = "0x7BBBAEB1C4", Slot = "86")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		// Token: 0x0600EA59 RID: 59993 RVA: 0x000424C8 File Offset: 0x000406C8
		[Token(Token = "0x600EA59")]
		[Address(RVA = "0x12C93C4", Offset = "0x12C93C4", VA = "0x7BBBAC93C4")]
		public Player.T[m GetPhysXState()
		{
			return Player.T[m.Walking;
		}

		// Token: 0x0600EA5A RID: 59994 RVA: 0x000424E0 File Offset: 0x000406E0
		[Token(Token = "0x600EA5A")]
		[Address(RVA = "0x12EB1F4", Offset = "0x12EB1F4", VA = "0x7BBBAEB1F4")]
		public VCDxuoO GetPhysXPose()
		{
			return VCDxuoO.EPHYSXPOSE_STANDING;
		}

		// Token: 0x0600EA5B RID: 59995 RVA: 0x000424F8 File Offset: 0x000406F8
		[Token(Token = "0x600EA5B")]
		[Address(RVA = "0x12C9364", Offset = "0x12C9364", VA = "0x7BBBAC9364")]
		public bool IsCrouching()
		{
			return default(bool);
		}

		// Token: 0x0600EA5C RID: 59996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA5C")]
		[Address(RVA = "0x12EB224", Offset = "0x12EB224", VA = "0x7BBBAEB224")]
		private void MgBo\u0080^K()
		{
		}

		// Token: 0x0600EA5D RID: 59997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA5D")]
		[Address(RVA = "0x12EB4D8", Offset = "0x12EB4D8", VA = "0x7BBBAEB4D8")]
		public void QuitRevive()
		{
		}

		// Token: 0x0600EA5E RID: 59998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA5E")]
		[Address(RVA = "0x12EB5B4", Offset = "0x12EB5B4", VA = "0x7BBBAEB5B4", Slot = "99")]
		public virtual void Dead(int HayvOap, {QAb\u0082~u zlP\u0080iaN, bool mHzuEX~ = false, bool w{NtXzW = false)
		{
		}

		// Token: 0x0600EA5F RID: 59999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA5F")]
		[Address(RVA = "0x12ED724", Offset = "0x12ED724", VA = "0x7BBBAED724", Slot = "100")]
		public virtual void UpdateController(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EA60 RID: 60000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA60")]
		[Address(RVA = "0x12ED788", Offset = "0x12ED788", VA = "0x7BBBAED788", Slot = "15")]
		public override void OnUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EA61 RID: 60001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA61")]
		[Address(RVA = "0x12EDB3C", Offset = "0x12EDB3C", VA = "0x7BBBAEDB3C", Slot = "101")]
		public virtual void OnPlayerBeTouch()
		{
		}

		// Token: 0x0600EA62 RID: 60002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA62")]
		[Address(RVA = "0x12EDD5C", Offset = "0x12EDD5C", VA = "0x7BBBAEDD5C")]
		public void CapsuleHumanTriggerEnter(Collider mvYAplG)
		{
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA63")]
		[Address(RVA = "0x12EDF40", Offset = "0x12EDF40", VA = "0x7BBBAEDF40")]
		public void CapsuleHumanTriggerExit(Collider mvYAplG)
		{
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x00042510 File Offset: 0x00040710
		[Token(Token = "0x600EA64")]
		[Address(RVA = "0x12EE05C", Offset = "0x12EE05C", VA = "0x7BBBAEE05C")]
		private bool Eao\u007FjUv(Collider mvYAplG)
		{
			return default(bool);
		}

		// Token: 0x0600EA65 RID: 60005 RVA: 0x00042528 File Offset: 0x00040728
		[Token(Token = "0x600EA65")]
		[Address(RVA = "0x12EE0F4", Offset = "0x12EE0F4", VA = "0x7BBBAEE0F4")]
		private bool <<EMPTY_NAME>>(aZ uNlNdAH, uint UM`{TIJ, byte Fw}qH[z)
		{
			return default(bool);
		}

		// Token: 0x0600EA66 RID: 60006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA66")]
		[Address(RVA = "0x12EE128", Offset = "0x12EE128", VA = "0x7BBBAEE128", Slot = "102")]
		public virtual void OnTriggerEnter(Collider mvYAplG)
		{
		}

		// Token: 0x0600EA67 RID: 60007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA67")]
		[Address(RVA = "0x12F4BE0", Offset = "0x12F4BE0", VA = "0x7BBBAF4BE0")]
		private void OnTriggerStay(Collider mvYAplG)
		{
		}

		// Token: 0x0600EA68 RID: 60008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA68")]
		[Address(RVA = "0x12F4F1C", Offset = "0x12F4F1C", VA = "0x7BBBAF4F1C", Slot = "103")]
		public virtual void OnTriggerExit(Collider mvYAplG)
		{
		}

		// Token: 0x0600EA69 RID: 60009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA69")]
		[Address(RVA = "0x12F8DD8", Offset = "0x12F8DD8", VA = "0x7BBBAF8DD8")]
		public void UpdateTriggerBtns()
		{
		}

		// Token: 0x0600EA6A RID: 60010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA6A")]
		[Address(RVA = "0x12F4CA4", Offset = "0x12F4CA4", VA = "0x7BBBAF4CA4")]
		private void m\u007FC\u0080W^s()
		{
		}

		// Token: 0x0600EA6B RID: 60011 RVA: 0x00042540 File Offset: 0x00040740
		[Token(Token = "0x600EA6B")]
		[Address(RVA = "0x12D18F8", Offset = "0x12D18F8", VA = "0x7BBBAD18F8")]
		public bool InSlider()
		{
			return default(bool);
		}

		// Token: 0x0600EA6C RID: 60012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA6C")]
		[Address(RVA = "0x12F1570", Offset = "0x12F1570", VA = "0x7BBBAF1570")]
		protected void g~o^\u0080w^(Collider mvYAplG)
		{
		}

		// Token: 0x0600EA6D RID: 60013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA6D")]
		[Address(RVA = "0x12F7ED4", Offset = "0x12F7ED4", VA = "0x7BBBAF7ED4")]
		protected void zIFI(Collider mvYAplG)
		{
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600EA6E RID: 60014 RVA: 0x00042558 File Offset: 0x00040758
		// (set) Token: 0x0600EA6F RID: 60015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700105B")]
		public ZykjDpa I{BWvzd
		{
			[Token(Token = "0x600EA6E")]
			[Address(RVA = "0x12F1A28", Offset = "0x12F1A28", VA = "0x7BBBAF1A28")]
			get
			{
				return ZykjDpa.None;
			}
			[Token(Token = "0x600EA6F")]
			[Address(RVA = "0x12F97F4", Offset = "0x12F97F4", VA = "0x7BBBAF97F4")]
			set
			{
			}
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA70")]
		[Address(RVA = "0x12F9750", Offset = "0x12F9750", VA = "0x7BBBAF9750")]
		private void cOMd\u0080{|()
		{
		}

		// Token: 0x0600EA71 RID: 60017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA71")]
		[Address(RVA = "0x12F8C98", Offset = "0x12F8C98", VA = "0x7BBBAF8C98")]
		private void J}XpFd{()
		{
		}

		// Token: 0x0600EA72 RID: 60018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA72")]
		[Address(RVA = "0x12F3308", Offset = "0x12F3308", VA = "0x7BBBAF3308")]
		protected void JedlbzW(aZ Dr~VNBn, uint EQcW~ws, byte JESbuC|, Vector3 ~qCR\u007Fd\u0080)
		{
		}

		// Token: 0x0600EA73 RID: 60019 RVA: 0x00042570 File Offset: 0x00040770
		[Token(Token = "0x600EA73")]
		[Address(RVA = "0x12FAC58", Offset = "0x12FAC58", VA = "0x7BBBAFAC58")]
		public bool CanUseAmmoBox()
		{
			return default(bool);
		}

		// Token: 0x0600EA74 RID: 60020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA74")]
		[Address(RVA = "0x12F8A18", Offset = "0x12F8A18", VA = "0x7BBBAF8A18")]
		private void xMf^J]Q()
		{
		}

		// Token: 0x0600EA75 RID: 60021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA75")]
		[Address(RVA = "0x12F9E94", Offset = "0x12F9E94", VA = "0x7BBBAF9E94")]
		private void X^LUEg|()
		{
		}

		// Token: 0x0600EA76 RID: 60022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA76")]
		[Address(RVA = "0x12F9BEC", Offset = "0x12F9BEC", VA = "0x7BBBAF9BEC")]
		private void Lds\u007F[Tq()
		{
		}

		// Token: 0x0600EA77 RID: 60023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA77")]
		[Address(RVA = "0x12F897C", Offset = "0x12F897C", VA = "0x7BBBAF897C")]
		private void uaEdHej()
		{
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA78")]
		[Address(RVA = "0x12F8AB4", Offset = "0x12F8AB4", VA = "0x7BBBAF8AB4")]
		private void ybtrO{w()
		{
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA79")]
		[Address(RVA = "0x12FA13C", Offset = "0x12FA13C", VA = "0x7BBBAFA13C")]
		private void mB()
		{
		}

		// Token: 0x0600EA7A RID: 60026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7A")]
		[Address(RVA = "0x12F863C", Offset = "0x12F863C", VA = "0x7BBBAF863C")]
		private void Tm\u0081wozA()
		{
		}

		// Token: 0x0600EA7B RID: 60027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7B")]
		[Address(RVA = "0x12FA3E4", Offset = "0x12FA3E4", VA = "0x7BBBAFA3E4")]
		private void ju^GQHp(ae}jEl\u0082 \u0081|ladnZ)
		{
		}

		// Token: 0x0600EA7C RID: 60028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7C")]
		[Address(RVA = "0x12FA6D0", Offset = "0x12FA6D0", VA = "0x7BBBAFA6D0")]
		private void yaQrLVJ()
		{
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7D")]
		[Address(RVA = "0x12F8B60", Offset = "0x12F8B60", VA = "0x7BBBAF8B60")]
		private void BiJU]OG()
		{
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7E")]
		[Address(RVA = "0x12F9814", Offset = "0x12F9814", VA = "0x7BBBAF9814")]
		private void hP\u0081EK\u007F\u0080(SJeBa PyEIVka = SJeBa.Mushroom)
		{
		}

		// Token: 0x0600EA7F RID: 60031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7F")]
		[Address(RVA = "0x12F88E0", Offset = "0x12F88E0", VA = "0x7BBBAF88E0")]
		private void hWKqHs^()
		{
		}

		// Token: 0x0600EA80 RID: 60032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA80")]
		[Address(RVA = "0x12FAD94", Offset = "0x12FAD94", VA = "0x7BBBAFAD94")]
		private void cMcSTP]()
		{
		}

		// Token: 0x0600EA81 RID: 60033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA81")]
		[Address(RVA = "0x12FBC90", Offset = "0x12FBC90", VA = "0x7BBBAFBC90")]
		private void LAsew]G()
		{
		}

		// Token: 0x0600EA82 RID: 60034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA82")]
		[Address(RVA = "0x12FBD84", Offset = "0x12FBD84", VA = "0x7BBBAFBD84")]
		private void WF^cTuz()
		{
		}

		// Token: 0x0600EA83 RID: 60035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA83")]
		[Address(RVA = "0x12F9808", Offset = "0x12F9808", VA = "0x7BBBAF9808")]
		private void MHVJnyP()
		{
		}

		// Token: 0x0600EA84 RID: 60036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA84")]
		[Address(RVA = "0x12F83F8", Offset = "0x12F83F8", VA = "0x7BBBAF83F8")]
		private void MHVJnyP(aZ ulZd\u0081oC, uint IbUpEoU)
		{
		}

		// Token: 0x0600EA85 RID: 60037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA85")]
		[Address(RVA = "0x12F9804", Offset = "0x12F9804", VA = "0x7BBBAF9804")]
		private void kY|hX()
		{
		}

		// Token: 0x0600EA86 RID: 60038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA86")]
		[Address(RVA = "0x12F93E8", Offset = "0x12F93E8", VA = "0x7BBBAF93E8")]
		private void r]YpC|L()
		{
		}

		// Token: 0x0600EA87 RID: 60039 RVA: 0x00042588 File Offset: 0x00040788
		[Token(Token = "0x600EA87")]
		[Address(RVA = "0x12F3278", Offset = "0x12F3278", VA = "0x7BBBAF3278")]
		public bool IsInTrigger()
		{
			return default(bool);
		}

		// Token: 0x0600EA88 RID: 60040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA88")]
		[Address(RVA = "0x12FC370", Offset = "0x12FC370", VA = "0x7BBBAFC370")]
		public void StopUsingItemOnHand()
		{
		}

		// Token: 0x0600EA89 RID: 60041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA89")]
		[Address(RVA = "0x12CC664", Offset = "0x12CC664", VA = "0x7BBBACC664", Slot = "76")]
		public AHtazwI GetItemOnHand()
		{
			return null;
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x000425A0 File Offset: 0x000407A0
		[Token(Token = "0x600EA8A")]
		[Address(RVA = "0x12FC3A4", Offset = "0x12FC3A4", VA = "0x7BBBAFC3A4")]
		public bool HasThrowingKnifeBROnHand()
		{
			return default(bool);
		}

		// Token: 0x0600EA8B RID: 60043 RVA: 0x000425B8 File Offset: 0x000407B8
		[Token(Token = "0x600EA8B")]
		[Address(RVA = "0x12FC48C", Offset = "0x12FC48C", VA = "0x7BBBAFC48C")]
		public int GetThrowingKnifeLegMountCount()
		{
			return 0;
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA8C")]
		[Address(RVA = "0x12FC5B8", Offset = "0x12FC5B8", VA = "0x7BBBAFC5B8", Slot = "77")]
		public AHtazwI GetRealItemOnHand()
		{
			return null;
		}

		// Token: 0x0600EA8D RID: 60045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EA8D")]
		[Address(RVA = "0x12FC5E8", Offset = "0x12FC5E8", VA = "0x7BBBAFC5E8")]
		public UserControlHandler GetUserControlHandler()
		{
			return null;
		}

		// Token: 0x0600EA8E RID: 60046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA8E")]
		[Address(RVA = "0x12FC5F0", Offset = "0x12FC5F0", VA = "0x7BBBAFC5F0", Slot = "14")]
		public override void OnFixedUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EA8F RID: 60047 RVA: 0x000425D0 File Offset: 0x000407D0
		[Token(Token = "0x600EA8F")]
		[Address(RVA = "0x12FC76C", Offset = "0x12FC76C", VA = "0x7BBBAFC76C")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		// Token: 0x0600EA90 RID: 60048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA90")]
		[Address(RVA = "0x12FC79C", Offset = "0x12FC79C", VA = "0x7BBBAFC79C", Slot = "104")]
		public virtual void UpdateAI(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EA91 RID: 60049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA91")]
		[Address(RVA = "0x12FC8A0", Offset = "0x12FC8A0", VA = "0x7BBBAFC8A0", Slot = "105")]
		public virtual void UpdateBehavior(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EA92 RID: 60050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA92")]
		[Address(RVA = "0x12FCC24", Offset = "0x12FCC24", VA = "0x7BBBAFCC24")]
		protected void ]\u007Fht}}S()
		{
		}

		// Token: 0x0600EA93 RID: 60051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA93")]
		[Address(RVA = "0x12FD098", Offset = "0x12FD098", VA = "0x7BBBAFD098")]
		protected void L{LRwu]()
		{
		}

		// Token: 0x0600EA94 RID: 60052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA94")]
		[Address(RVA = "0x12FD194", Offset = "0x12FD194", VA = "0x7BBBAFD194", Slot = "106")]
		public virtual void UpdateKinematics(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EA95 RID: 60053 RVA: 0x000425E8 File Offset: 0x000407E8
		[Token(Token = "0x600EA95")]
		[Address(RVA = "0x1304748", Offset = "0x1304748", VA = "0x7BBBB04748")]
		public bool IsMoving()
		{
			return default(bool);
		}

		// Token: 0x0600EA96 RID: 60054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA96")]
		[Address(RVA = "0x1304730", Offset = "0x1304730", VA = "0x7BBBB04730")]
		private void }XnO~XW(bool fCPtuHj)
		{
		}

		// Token: 0x0600EA97 RID: 60055 RVA: 0x00042600 File Offset: 0x00040800
		[Token(Token = "0x600EA97")]
		[Address(RVA = "0x1304C04", Offset = "0x1304C04", VA = "0x7BBBB04C04")]
		protected bool ic\u0081(Vector3 FPwnAPU)
		{
			return default(bool);
		}

		// Token: 0x0600EA98 RID: 60056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA98")]
		[Address(RVA = "0x1304DA4", Offset = "0x1304DA4", VA = "0x7BBBB04DA4")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x00042618 File Offset: 0x00040818
		[Token(Token = "0x600EA99")]
		[Address(RVA = "0x1305878", Offset = "0x1305878", VA = "0x7BBBB05878")]
		protected bool KFNgLjN()
		{
			return default(bool);
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA9A")]
		[Address(RVA = "0x1305914", Offset = "0x1305914", VA = "0x7BBBB05914")]
		protected void [zSjC\u007F|()
		{
		}

		// Token: 0x0600EA9B RID: 60059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA9B")]
		[Address(RVA = "0x13052D8", Offset = "0x13052D8", VA = "0x7BBBB052D8")]
		protected void RNF\u007FHGK()
		{
		}

		// Token: 0x0600EA9C RID: 60060 RVA: 0x00042630 File Offset: 0x00040830
		[Token(Token = "0x600EA9C")]
		[Address(RVA = "0x1305FA0", Offset = "0x1305FA0", VA = "0x7BBBB05FA0")]
		protected bool [Bi~Vvg(Transform B~NRjTI)
		{
			return default(bool);
		}

		// Token: 0x0600EA9D RID: 60061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA9D")]
		[Address(RVA = "0x13063F0", Offset = "0x13063F0", VA = "0x7BBBB063F0")]
		protected void wzqOIXN(Transform B~NRjTI, float UJx`cvv = 0f, float ][epIQ| = 0f, bool n\u0081wfywc = false)
		{
		}

		// Token: 0x0600EA9E RID: 60062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA9E")]
		[Address(RVA = "0x13067DC", Offset = "0x13067DC", VA = "0x7BBBB067DC", Slot = "107")]
		public virtual void PostUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EA9F RID: 60063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA9F")]
		[Address(RVA = "0x12FD9B4", Offset = "0x12FD9B4", VA = "0x7BBBAFD9B4")]
		private void aqbGJYi(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EAA0 RID: 60064 RVA: 0x00042648 File Offset: 0x00040848
		[Token(Token = "0x600EAA0")]
		[Address(RVA = "0x13093E4", Offset = "0x13093E4", VA = "0x7BBBB093E4")]
		private float hM}Srsf(Vector3 }LBVshd, float wXN]Cdx)
		{
			return 0f;
		}

		// Token: 0x0600EAA1 RID: 60065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA1")]
		[Address(RVA = "0x13098D0", Offset = "0x13098D0", VA = "0x7BBBB098D0", Slot = "108")]
		public virtual void OnLandFinsish()
		{
		}

		// Token: 0x0600EAA2 RID: 60066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA2")]
		[Address(RVA = "0x1309C1C", Offset = "0x1309C1C", VA = "0x7BBBB09C1C")]
		public void ShowLandingTutorial()
		{
		}

		// Token: 0x0600EAA3 RID: 60067 RVA: 0x00042660 File Offset: 0x00040860
		[Token(Token = "0x600EAA3")]
		[Address(RVA = "0x1309E48", Offset = "0x1309E48", VA = "0x7BBBB09E48", Slot = "80")]
		public bool IsTargetFriend(\u0081{oGdwC VT`lIxO)
		{
			return default(bool);
		}

		// Token: 0x0600EAA4 RID: 60068 RVA: 0x00042678 File Offset: 0x00040878
		[Token(Token = "0x600EAA4")]
		[Address(RVA = "0x12FBC7C", Offset = "0x12FBC7C", VA = "0x7BBBAFBC7C")]
		public Quaternion GetAimRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x0600EAA5 RID: 60069 RVA: 0x00042690 File Offset: 0x00040890
		[Token(Token = "0x600EAA5")]
		[Address(RVA = "0x130A17C", Offset = "0x130A17C", VA = "0x7BBBB0A17C")]
		public Quaternion GetAuxAimRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x0600EAA6 RID: 60070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA6")]
		[Address(RVA = "0x130A1D4", Offset = "0x130A1D4", VA = "0x7BBBB0A1D4")]
		public void ResetAuxAimRotation()
		{
		}

		// Token: 0x0600EAA7 RID: 60071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAA7")]
		[Address(RVA = "0x130A1F0", Offset = "0x130A1F0", VA = "0x7BBBB0A1F0", Slot = "109")]
		public virtual void PauseAnimator()
		{
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600EAA8 RID: 60072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105C")]
		public MDsfkBx iMAzVwG
		{
			[Token(Token = "0x600EAA8")]
			[Address(RVA = "0x130A288", Offset = "0x130A288", VA = "0x7BBBB0A288")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600EAA9 RID: 60073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700105D")]
		private MDsfkBx SeyKshe
		{
			[Token(Token = "0x600EAA9")]
			[Address(RVA = "0x130A290", Offset = "0x130A290", VA = "0x7BBBB0A290")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x0600EAAA RID: 60074 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EAAB RID: 60075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700105E")]
		public \u0081{oGdwC A^^}l^H
		{
			[Token(Token = "0x600EAAA")]
			[Address(RVA = "0x130A298", Offset = "0x130A298", VA = "0x7BBBB0A298", Slot = "78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A604", Offset = "0x114A604")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EAAB")]
			[Address(RVA = "0x130A2A0", Offset = "0x130A2A0", VA = "0x7BBBB0A2A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A614", Offset = "0x114A614")]
			private set
			{
			}
		}

		// Token: 0x0600EAAC RID: 60076 RVA: 0x000426A8 File Offset: 0x000408A8
		[Token(Token = "0x600EAAC")]
		[Address(RVA = "0x130A2A8", Offset = "0x130A2A8", VA = "0x7BBBB0A2A8", Slot = "79")]
		public bool HasHeuristicTarget()
		{
			return default(bool);
		}

		// Token: 0x0600EAAD RID: 60077 RVA: 0x000426C0 File Offset: 0x000408C0
		[Token(Token = "0x600EAAD")]
		[Address(RVA = "0x130A408", Offset = "0x130A408", VA = "0x7BBBB0A408")]
		public Vector3 GetWeaponTraceStartPos()
		{
			return default(Vector3);
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x0600EAAE RID: 60078 RVA: 0x000426D8 File Offset: 0x000408D8
		[Token(Token = "0x1700105F")]
		public Vector3 WHn{Gds
		{
			[Token(Token = "0x600EAAE")]
			[Address(RVA = "0x130A5CC", Offset = "0x130A5CC", VA = "0x7BBBB0A5CC")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600EAAF RID: 60079 RVA: 0x000426F0 File Offset: 0x000408F0
		[Token(Token = "0x17001060")]
		public Vector3 Wr|TD\u007Fn
		{
			[Token(Token = "0x600EAAF")]
			[Address(RVA = "0x130A6F0", Offset = "0x130A6F0", VA = "0x7BBBB0A6F0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600EAB0 RID: 60080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB0")]
		[Address(RVA = "0x130A7AC", Offset = "0x130A7AC", VA = "0x7BBBB0A7AC", Slot = "110")]
		public virtual void UpdateAiming(float \u0081}x[tOF, float OsUltaA, bool rrQzbf^ = false)
		{
		}

		// Token: 0x0600EAB1 RID: 60081 RVA: 0x00042708 File Offset: 0x00040908
		[Token(Token = "0x600EAB1")]
		[Address(RVA = "0x130BAA0", Offset = "0x130BAA0", VA = "0x7BBBB0BAA0")]
		public bool IsAmimingSelfGunShield(Collider XRNiDep)
		{
			return default(bool);
		}

		// Token: 0x0600EAB2 RID: 60082 RVA: 0x00042720 File Offset: 0x00040920
		[Token(Token = "0x600EAB2")]
		[Address(RVA = "0x130BC80", Offset = "0x130BC80", VA = "0x7BBBB0BC80")]
		public bool IsAmimingSelfVehicleShield(Collider XRNiDep)
		{
			return default(bool);
		}

		// Token: 0x0600EAB3 RID: 60083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB3")]
		[Address(RVA = "0x130BE40", Offset = "0x130BE40", VA = "0x7BBBB0BE40", Slot = "48")]
		public override void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint iYO}d|F = 0U)
		{
		}

		// Token: 0x0600EAB4 RID: 60084 RVA: 0x00042738 File Offset: 0x00040938
		[Token(Token = "0x600EAB4")]
		[Address(RVA = "0x130BF7C", Offset = "0x130BF7C", VA = "0x7BBBB0BF7C", Slot = "111")]
		public virtual int TakeDamage(int muv\u0081n{r, {QAb\u0082~u zlP\u0080iaN, [Optional] woZmHkA JkgWmeJ, int dwdYABP = -1, [Optional] Vector3 `oVk\u0080^H, [Optional] Vector3 ft|sF}F, [Optional] List<float> `KEFVvE, [Optional] ohSG[ek \u0081{zLQ\u007FM, uint iYO}d|F = 0U)
		{
			return 0;
		}

		// Token: 0x0600EAB5 RID: 60085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB5")]
		[Address(RVA = "0x130D6E4", Offset = "0x130D6E4", VA = "0x7BBBB0D6E4", Slot = "49")]
		public override void TakeHealing(int wE~rpy\u0082, {QAb\u0082~u a\u0082uxIoj, int dwdYABP, [Optional] Vector3 `oVk\u0080^H, [Optional] Vector3 ft|sF}F, [Optional] List<float> `KEFVvE)
		{
		}

		// Token: 0x0600EAB6 RID: 60086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB6")]
		[Address(RVA = "0x130DC58", Offset = "0x130DC58", VA = "0x7BBBB0DC58")]
		public void ShowFireInfoInMap(byte yfq{tix)
		{
		}

		// Token: 0x0600EAB7 RID: 60087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB7")]
		[Address(RVA = "0x130D42C", Offset = "0x130D42C", VA = "0x7BBBB0D42C")]
		public void PlaySpeedRoyalBGM(int dwdYABP)
		{
		}

		// Token: 0x0600EAB8 RID: 60088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB8")]
		[Address(RVA = "0x130E488", Offset = "0x130E488", VA = "0x7BBBB0E488", Slot = "112")]
		public virtual void PlayFireEffect(ytMNhlw ~y\u0081WoSG)
		{
		}

		// Token: 0x0600EAB9 RID: 60089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAB9")]
		[Address(RVA = "0x130E4BC", Offset = "0x130E4BC", VA = "0x7BBBB0E4BC", Slot = "113")]
		public virtual void PlayCureAnimation(bool VpPFSrR)
		{
		}

		// Token: 0x0600EABA RID: 60090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABA")]
		[Address(RVA = "0x130E52C", Offset = "0x130E52C", VA = "0x7BBBB0E52C")]
		private void e`Tv\u0082(bool VpPFSrR)
		{
		}

		// Token: 0x0600EABB RID: 60091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABB")]
		[Address(RVA = "0x130E6F4", Offset = "0x130E6F4", VA = "0x7BBBB0E6F4", Slot = "114")]
		public virtual void PlaySetBombAnimation(bool VpPFSrR)
		{
		}

		// Token: 0x0600EABC RID: 60092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABC")]
		[Address(RVA = "0x130EA00", Offset = "0x130EA00", VA = "0x7BBBB0EA00")]
		public void PlayADSTeleportAnimation()
		{
		}

		// Token: 0x0600EABD RID: 60093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABD")]
		[Address(RVA = "0x130EBD8", Offset = "0x130EBD8", VA = "0x7BBBB0EBD8")]
		public void ShowADSPortalEffect(bool \u0081OTRX|}, Player.o{jS DU[lxOk)
		{
		}

		// Token: 0x0600EABE RID: 60094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABE")]
		[Address(RVA = "0x130F098", Offset = "0x130F098", VA = "0x7BBBB0F098")]
		public void ShowADSBodyEffect(bool \u0081OTRX|})
		{
		}

		// Token: 0x0600EABF RID: 60095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EABF")]
		[Address(RVA = "0x130F260", Offset = "0x130F260", VA = "0x7BBBB0F260")]
		public void ShowADSWinBuffEffect(bool \u0081OTRX|})
		{
		}

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EAC0")]
		[Address(RVA = "0x130EE54", Offset = "0x130EE54", VA = "0x7BBBB0EE54")]
		private GameObject \u0082kkgruJ(Player.o{jS DU[lxOk)
		{
			return null;
		}

		// Token: 0x0600EAC1 RID: 60097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC1")]
		[Address(RVA = "0x130F530", Offset = "0x130F530", VA = "0x7BBBB0F530")]
		public void PlayUsePacemakerAnimation(bool VpPFSrR, uint SfusqvD = 0U)
		{
		}

		// Token: 0x0600EAC2 RID: 60098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC2")]
		[Address(RVA = "0x130F8B8", Offset = "0x130F8B8", VA = "0x7BBBB0F8B8")]
		public void CreatePacemakerInAnim()
		{
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC3")]
		[Address(RVA = "0x130FBAC", Offset = "0x130FBAC", VA = "0x7BBBB0FBAC")]
		public void PlayUsePacemakerHeartBeatAudio()
		{
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC4")]
		[Address(RVA = "0x12ED52C", Offset = "0x12ED52C", VA = "0x7BBBAED52C")]
		public void ClearPacemaker()
		{
		}

		// Token: 0x0600EAC5 RID: 60101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC5")]
		[Address(RVA = "0x130FC8C", Offset = "0x130FC8C", VA = "0x7BBBB0FC8C")]
		public void PlaySelfRescureGetUpEffect()
		{
		}

		// Token: 0x0600EAC6 RID: 60102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC6")]
		[Address(RVA = "0x12ED498", Offset = "0x12ED498", VA = "0x7BBBAED498")]
		public void ResetPlayerRescureReason()
		{
		}

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC7")]
		[Address(RVA = "0x1310050", Offset = "0x1310050", VA = "0x7BBBB10050", Slot = "115")]
		public virtual void PlayPreparationAnimation(bool VpPFSrR, EPreparationTimerType PyEIVka)
		{
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC8")]
		[Address(RVA = "0x131015C", Offset = "0x131015C", VA = "0x7BBBB1015C", Slot = "116")]
		public virtual void StartFiring(ytMNhlw ~y\u0081WoSG)
		{
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAC9")]
		[Address(RVA = "0x1310330", Offset = "0x1310330", VA = "0x7BBBB10330", Slot = "117")]
		public virtual void StartWarmUp(ytMNhlw ~y\u0081WoSG)
		{
		}

		// Token: 0x0600EACA RID: 60106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACA")]
		[Address(RVA = "0x1310334", Offset = "0x1310334", VA = "0x7BBBB10334", Slot = "118")]
		public virtual void StopFire(ytMNhlw ~y\u0081WoSG)
		{
		}

		// Token: 0x0600EACB RID: 60107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACB")]
		[Address(RVA = "0x13104D4", Offset = "0x13104D4", VA = "0x7BBBB104D4")]
		public void OnReloadingNoBullet(ytMNhlw ~y\u0081WoSG)
		{
		}

		// Token: 0x0600EACC RID: 60108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EACC")]
		[Address(RVA = "0x13107F8", Offset = "0x13107F8", VA = "0x7BBBB107F8", Slot = "119")]
		public virtual void StopCharge(ytMNhlw ~y\u0081WoSG)
		{
		}

		// Token: 0x0600EACD RID: 60109 RVA: 0x00042750 File Offset: 0x00040950
		[Token(Token = "0x600EACD")]
		[Address(RVA = "0x13107FC", Offset = "0x13107FC", VA = "0x7BBBB107FC", Slot = "120")]
		public virtual bool GetSightingState()
		{
			return default(bool);
		}

		// Token: 0x0600EACE RID: 60110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EACE")]
		[Address(RVA = "0x13108AC", Offset = "0x13108AC", VA = "0x7BBBB108AC")]
		public b^\u0082T]gJ GetWeaponSightingAttachmentData()
		{
			return null;
		}

		// Token: 0x0600EACF RID: 60111 RVA: 0x00042768 File Offset: 0x00040968
		[Token(Token = "0x600EACF")]
		[Address(RVA = "0x13108D0", Offset = "0x13108D0", VA = "0x7BBBB108D0", Slot = "121")]
		public virtual bool IsSightingUIAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600EAD0 RID: 60112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD0")]
		[Address(RVA = "0x1310990", Offset = "0x1310990", VA = "0x7BBBB10990")]
		public void OnAnimationVisibilityChanged(int ruRrDpa)
		{
		}

		// Token: 0x0600EAD1 RID: 60113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD1")]
		[Address(RVA = "0x13109AC", Offset = "0x13109AC", VA = "0x7BBBB109AC")]
		public void OnAnimEvent(\u0081X j^EfuAq, params object[] ruRrDpa)
		{
		}

		// Token: 0x0600EAD2 RID: 60114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD2")]
		[Address(RVA = "0x13112A8", Offset = "0x13112A8", VA = "0x7BBBB112A8")]
		private void [W^gwHq(bool \u0082inlXAP)
		{
		}

		// Token: 0x0600EAD3 RID: 60115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD3")]
		[Address(RVA = "0x13110BC", Offset = "0x13110BC", VA = "0x7BBBB110BC")]
		private void \u0081{eK}Tx(bool eB~xJ]P)
		{
		}

		// Token: 0x0600EAD4 RID: 60116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD4")]
		[Address(RVA = "0x1311408", Offset = "0x1311408", VA = "0x7BBBB11408", Slot = "83")]
		public void OnSightingUIStateChange(bool Xxi|B^k, float jIVHyjd)
		{
		}

		// Token: 0x0600EAD5 RID: 60117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD5")]
		[Address(RVA = "0x1311D70", Offset = "0x1311D70", VA = "0x7BBBB11D70", Slot = "122")]
		public virtual void SwapWeapon(int rxVzo\u0081E, bool yKoX]\u0080Y = false)
		{
		}

		// Token: 0x0600EAD6 RID: 60118 RVA: 0x00042780 File Offset: 0x00040980
		[Token(Token = "0x600EAD6")]
		[Address(RVA = "0x1312010", Offset = "0x1312010", VA = "0x7BBBB12010")]
		private bool kXK\u007FQ[H(ByGSUuj |sYOyQA, AHtazwI [ehnGd})
		{
			return default(bool);
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD7")]
		[Address(RVA = "0x131212C", Offset = "0x131212C", VA = "0x7BBBB1212C", Slot = "123")]
		public virtual void SwapWeapon(ByGSUuj |sYOyQA, bool yKoX]\u0080Y = false)
		{
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD8")]
		[Address(RVA = "0x13124A0", Offset = "0x13124A0", VA = "0x7BBBB124A0", Slot = "124")]
		public virtual void ReloadWeapon()
		{
		}

		// Token: 0x0600EAD9 RID: 60121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD9")]
		[Address(RVA = "0x13124D4", Offset = "0x13124D4", VA = "0x7BBBB124D4", Slot = "125")]
		public virtual void FullWeaponAmmo()
		{
		}

		// Token: 0x0600EADA RID: 60122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADA")]
		[Address(RVA = "0x1312504", Offset = "0x1312504", VA = "0x7BBBB12504", Slot = "126")]
		public virtual void OnGrenadeStartFire()
		{
		}

		// Token: 0x0600EADB RID: 60123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADB")]
		[Address(RVA = "0x1312540", Offset = "0x1312540", VA = "0x7BBBB12540", Slot = "127")]
		public virtual void OnGrenadeEndFire()
		{
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADC")]
		[Address(RVA = "0x131257C", Offset = "0x131257C", VA = "0x7BBBB1257C", Slot = "128")]
		public virtual void OnThrowKnifeStartFire()
		{
		}

		// Token: 0x0600EADD RID: 60125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADD")]
		[Address(RVA = "0x13125B8", Offset = "0x13125B8", VA = "0x7BBBB125B8", Slot = "129")]
		public virtual void OnThrowKnifeEndFire()
		{
		}

		// Token: 0x0600EADE RID: 60126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADE")]
		[Address(RVA = "0x13125F4", Offset = "0x13125F4", VA = "0x7BBBB125F4", Slot = "130")]
		public virtual void OnGrenadeQuitFire()
		{
		}

		// Token: 0x0600EADF RID: 60127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EADF")]
		[Address(RVA = "0x131260C", Offset = "0x131260C", VA = "0x7BBBB1260C", Slot = "131")]
		public virtual void OnBeginPutDown()
		{
		}

		// Token: 0x0600EAE0 RID: 60128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE0")]
		[Address(RVA = "0x1312694", Offset = "0x1312694", VA = "0x7BBBB12694", Slot = "132")]
		public virtual void OnWeaponLift(bool VzdyUz^ = false)
		{
		}

		// Token: 0x0600EAE1 RID: 60129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE1")]
		[Address(RVA = "0x13126EC", Offset = "0x13126EC", VA = "0x7BBBB126EC", Slot = "133")]
		public virtual void OnWeaponPutDown()
		{
		}

		// Token: 0x0600EAE2 RID: 60130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE2")]
		[Address(RVA = "0x1312758", Offset = "0x1312758", VA = "0x7BBBB12758", Slot = "134")]
		public virtual void OnWeaponReloadStarted(float ~BoGDTv, bool Wh}bbe} = false)
		{
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE3")]
		[Address(RVA = "0x13127BC", Offset = "0x13127BC", VA = "0x7BBBB127BC", Slot = "135")]
		public virtual void OnWeaponReloadFinished()
		{
		}

		// Token: 0x0600EAE4 RID: 60132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE4")]
		[Address(RVA = "0x13127C0", Offset = "0x13127C0", VA = "0x7BBBB127C0")]
		public void OnWeaponReloadDone()
		{
		}

		// Token: 0x0600EAE5 RID: 60133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE5")]
		[Address(RVA = "0x1312808", Offset = "0x1312808", VA = "0x7BBBB12808", Slot = "136")]
		public virtual void OnSniperPullBoltStarted(float ~BoGDTv)
		{
		}

		// Token: 0x0600EAE6 RID: 60134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE6")]
		[Address(RVA = "0x1312864", Offset = "0x1312864", VA = "0x7BBBB12864", Slot = "137")]
		public virtual void OnSniperPullBoltFinished()
		{
		}

		// Token: 0x0600EAE7 RID: 60135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE7")]
		[Address(RVA = "0x1312868", Offset = "0x1312868", VA = "0x7BBBB12868")]
		public void OnSniperPullBoltDone()
		{
		}

		// Token: 0x0600EAE8 RID: 60136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAE8")]
		[Address(RVA = "0x1312898", Offset = "0x1312898", VA = "0x7BBBB12898")]
		public void PlayChangeWeaponSoundInternal()
		{
		}

		// Token: 0x0600EAE9 RID: 60137 RVA: 0x00042798 File Offset: 0x00040998
		[Token(Token = "0x600EAE9")]
		[Address(RVA = "0x130523C", Offset = "0x130523C", VA = "0x7BBBB0523C")]
		protected bool AqT|cJX()
		{
			return default(bool);
		}

		// Token: 0x0600EAEA RID: 60138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEA")]
		[Address(RVA = "0x1312930", Offset = "0x1312930", VA = "0x7BBBB12930")]
		public void StartJumpOffAirTransporter()
		{
		}

		// Token: 0x0600EAEB RID: 60139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEB")]
		[Address(RVA = "0x1312CE8", Offset = "0x1312CE8", VA = "0x7BBBB12CE8")]
		protected void J{tICh|()
		{
		}

		// Token: 0x0600EAEC RID: 60140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEC")]
		[Address(RVA = "0x131339C", Offset = "0x131339C", VA = "0x7BBBB1339C")]
		protected void mcwGBPC()
		{
		}

		// Token: 0x0600EAED RID: 60141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAED")]
		[Address(RVA = "0x1313440", Offset = "0x1313440", VA = "0x7BBBB13440")]
		protected void c^owO]}()
		{
		}

		// Token: 0x0600EAEE RID: 60142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEE")]
		[Address(RVA = "0x1313B88", Offset = "0x1313B88", VA = "0x7BBBB13B88")]
		protected void Zn\u0081gMO{()
		{
		}

		// Token: 0x0600EAEF RID: 60143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAEF")]
		[Address(RVA = "0x12ECDC8", Offset = "0x12ECDC8", VA = "0x7BBBAECDC8")]
		protected void {EiKxC}()
		{
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF0")]
		[Address(RVA = "0x1313E80", Offset = "0x1313E80", VA = "0x7BBBB13E80")]
		private void T|RooP{()
		{
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF1")]
		[Address(RVA = "0x1313FB8", Offset = "0x1313FB8", VA = "0x7BBBB13FB8")]
		protected void QZjepeq()
		{
		}

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF2")]
		[Address(RVA = "0x12ECDCC", Offset = "0x12ECDCC", VA = "0x7BBBAECDCC")]
		protected void cTcPNE\u007F()
		{
		}

		// Token: 0x0600EAF3 RID: 60147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF3")]
		[Address(RVA = "0x13142BC", Offset = "0x13142BC", VA = "0x7BBBB142BC")]
		private void bYXLdVw()
		{
		}

		// Token: 0x0600EAF4 RID: 60148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF4")]
		[Address(RVA = "0x12ECCF4", Offset = "0x12ECCF4", VA = "0x7BBBAECCF4")]
		protected void p\u0080qfmlW()
		{
		}

		// Token: 0x0600EAF5 RID: 60149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF5")]
		[Address(RVA = "0x13143F4", Offset = "0x13143F4", VA = "0x7BBBB143F4")]
		public void StartSkyDiving()
		{
		}

		// Token: 0x0600EAF6 RID: 60150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF6")]
		[Address(RVA = "0x12E309C", Offset = "0x12E309C", VA = "0x7BBBAE309C")]
		private void ^D{ZXpd()
		{
		}

		// Token: 0x0600EAF7 RID: 60151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAF7")]
		[Address(RVA = "0x1314A70", Offset = "0x1314A70", VA = "0x7BBBB14A70")]
		private void up\u0080Afqx()
		{
		}

		// Token: 0x0600EAF8 RID: 60152 RVA: 0x000427B0 File Offset: 0x000409B0
		[Token(Token = "0x600EAF8")]
		[Address(RVA = "0x131397C", Offset = "0x131397C", VA = "0x7BBBB1397C")]
		private bool ABYJsq]()
		{
			return default(bool);
		}

		// Token: 0x0600EAF9 RID: 60153 RVA: 0x000427C8 File Offset: 0x000409C8
		[Token(Token = "0x600EAF9")]
		[Address(RVA = "0x1314C8C", Offset = "0x1314C8C", VA = "0x7BBBB14C8C")]
		private bool aY()
		{
			return default(bool);
		}

		// Token: 0x0600EAFA RID: 60154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAFA")]
		[Address(RVA = "0x1314C38", Offset = "0x1314C38", VA = "0x7BBBB14C38")]
		private void jc^zcO{()
		{
		}

		// Token: 0x0600EAFB RID: 60155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAFB")]
		[Address(RVA = "0x12E561C", Offset = "0x12E561C", VA = "0x7BBBAE561C")]
		private void YfSJssy()
		{
		}

		// Token: 0x0600EAFC RID: 60156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAFC")]
		[Address(RVA = "0x1314DC0", Offset = "0x1314DC0", VA = "0x7BBBB14DC0")]
		private void BJ~hSLl()
		{
		}

		// Token: 0x0600EAFD RID: 60157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAFD")]
		[Address(RVA = "0x12E56C8", Offset = "0x12E56C8", VA = "0x7BBBAE56C8")]
		private void A|S\u0082KH[()
		{
		}

		// Token: 0x0600EAFE RID: 60158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAFE")]
		[Address(RVA = "0x1314DC4", Offset = "0x1314DC4", VA = "0x7BBBB14DC4")]
		public void StopParachuting(bool n|`YSUX = true)
		{
		}

		// Token: 0x0600EAFF RID: 60159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAFF")]
		[Address(RVA = "0x13151DC", Offset = "0x13151DC", VA = "0x7BBBB151DC")]
		private void ||hueqi()
		{
		}

		// Token: 0x0600EB00 RID: 60160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB00")]
		[Address(RVA = "0x131527C", Offset = "0x131527C", VA = "0x7BBBB1527C")]
		private void hN\u0080SZKr()
		{
		}

		// Token: 0x0600EB01 RID: 60161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB01")]
		[Address(RVA = "0x131531C", Offset = "0x131531C", VA = "0x7BBBB1531C")]
		private void gDD\u007FJK\u0081()
		{
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB02")]
		[Address(RVA = "0x1315704", Offset = "0x1315704", VA = "0x7BBBB15704")]
		public void StartParachuting()
		{
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB03")]
		[Address(RVA = "0x13156B0", Offset = "0x13156B0", VA = "0x7BBBB156B0")]
		private void ILxHql^()
		{
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB04")]
		[Address(RVA = "0x1315ED0", Offset = "0x1315ED0", VA = "0x7BBBB15ED0")]
		public void PlayHypeFireEffect(int zu\u0080`ZNd, int fCoh[zl = -1)
		{
		}

		// Token: 0x0600EB05 RID: 60165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB05")]
		[Address(RVA = "0x13163A4", Offset = "0x13163A4", VA = "0x7BBBB163A4")]
		private void ujypMqx()
		{
		}

		// Token: 0x0600EB06 RID: 60166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB06")]
		[Address(RVA = "0x1316718", Offset = "0x1316718", VA = "0x7BBBB16718")]
		protected void qlRNPwj(int fCoh[zl, int BCcewvq)
		{
		}

		// Token: 0x0600EB07 RID: 60167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB07")]
		[Address(RVA = "0x1316A80", Offset = "0x1316A80", VA = "0x7BBBB16A80", Slot = "138")]
		public virtual void BeforeSwitchAnimController(bool vgGdFMi = false)
		{
		}

		// Token: 0x0600EB08 RID: 60168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB08")]
		[Address(RVA = "0x1316AF4", Offset = "0x1316AF4", VA = "0x7BBBB16AF4", Slot = "139")]
		public virtual void SwitchAnimController()
		{
		}

		// Token: 0x0600EB09 RID: 60169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB09")]
		[Address(RVA = "0x1316C04", Offset = "0x1316C04", VA = "0x7BBBB16C04")]
		public void SetAsDriver()
		{
		}

		// Token: 0x0600EB0A RID: 60170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB0A")]
		[Address(RVA = "0x1316C48", Offset = "0x1316C48", VA = "0x7BBBB16C48", Slot = "140")]
		public virtual void PlayChangeVehicleSeatAnimation(bool {\u007Fek}Kt)
		{
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB0B")]
		[Address(RVA = "0x1316CE4", Offset = "0x1316CE4", VA = "0x7BBBB16CE4")]
		public void ShowBagPack()
		{
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB0C")]
		[Address(RVA = "0x1316D50", Offset = "0x1316D50", VA = "0x7BBBB16D50")]
		public void HideBagPack()
		{
		}

		// Token: 0x0600EB0D RID: 60173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB0D")]
		[Address(RVA = "0x1316DC0", Offset = "0x1316DC0", VA = "0x7BBBB16DC0")]
		public void OnStartChangeWeapon(ytMNhlw ~~\u0080gGPa)
		{
		}

		// Token: 0x0600EB0E RID: 60174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB0E")]
		[Address(RVA = "0x1317078", Offset = "0x1317078", VA = "0x7BBBB17078", Slot = "141")]
		public virtual void ResizeSniperFireCollider(float nMm^Ond, float BJeTyvB, float fGV^E\u0081Z = -1f, bool pO|\u0082r}i = false)
		{
		}

		// Token: 0x0600EB0F RID: 60175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB0F")]
		[Address(RVA = "0x1317278", Offset = "0x1317278", VA = "0x7BBBB17278", Slot = "142")]
		public virtual void ResizeCapsuleCollider(float nMm^Ond, float BJeTyvB = -1f, float ~A~Y}n[ = 0f)
		{
		}

		// Token: 0x0600EB10 RID: 60176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB10")]
		[Address(RVA = "0x12E67D4", Offset = "0x12E67D4", VA = "0x7BBBAE67D4")]
		protected void fVSVVnn(bool j^EfuAq)
		{
		}

		// Token: 0x0600EB11 RID: 60177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB11")]
		[Address(RVA = "0x13174F8", Offset = "0x13174F8", VA = "0x7BBBB174F8")]
		public void OnFireModeChanged(bool krpTOxJ)
		{
		}

		// Token: 0x0600EB12 RID: 60178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB12")]
		[Address(RVA = "0x1317578", Offset = "0x1317578", VA = "0x7BBBB17578", Slot = "143")]
		public virtual Transform GetHeadTF()
		{
			return null;
		}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB13")]
		[Address(RVA = "0x1317650", Offset = "0x1317650", VA = "0x7BBBB17650", Slot = "144")]
		public virtual Transform GetHipTF()
		{
			return null;
		}

		// Token: 0x0600EB14 RID: 60180 RVA: 0x000427E0 File Offset: 0x000409E0
		[Token(Token = "0x600EB14")]
		[Address(RVA = "0x1317728", Offset = "0x1317728", VA = "0x7BBBB17728", Slot = "145")]
		protected virtual Vector3 \u007Fv|uMSB()
		{
			return default(Vector3);
		}

		// Token: 0x0600EB15 RID: 60181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB15")]
		[Address(RVA = "0x1317814", Offset = "0x1317814", VA = "0x7BBBB17814", Slot = "146")]
		public virtual Transform GetLeftAnkleTF()
		{
			return null;
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB16")]
		[Address(RVA = "0x131781C", Offset = "0x131781C", VA = "0x7BBBB1781C", Slot = "147")]
		public virtual Transform GetRightAnkleTF()
		{
			return null;
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB17")]
		[Address(RVA = "0x1317824", Offset = "0x1317824", VA = "0x7BBBB17824", Slot = "148")]
		public virtual Transform GetLeftToeTF()
		{
			return null;
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB18")]
		[Address(RVA = "0x131782C", Offset = "0x131782C", VA = "0x7BBBB1782C", Slot = "149")]
		public virtual Transform GetRightToeTF()
		{
			return null;
		}

		// Token: 0x0600EB19 RID: 60185 RVA: 0x000427F8 File Offset: 0x000409F8
		[Token(Token = "0x600EB19")]
		[Address(RVA = "0x1317834", Offset = "0x1317834", VA = "0x7BBBB17834", Slot = "150")]
		public virtual Vector3 GetCharacterControllerTopPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x00042810 File Offset: 0x00040A10
		[Token(Token = "0x600EB1A")]
		[Address(RVA = "0x12F19F8", Offset = "0x12F19F8", VA = "0x7BBBAF19F8")]
		public float GetCharacterHeight()
		{
			return 0f;
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x00042828 File Offset: 0x00040A28
		[Token(Token = "0x600EB1B")]
		[Address(RVA = "0x131789C", Offset = "0x131789C", VA = "0x7BBBB1789C")]
		public float GetCharacterCenterY()
		{
			return 0f;
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB1C")]
		[Address(RVA = "0x130B8D0", Offset = "0x130B8D0", VA = "0x7BBBB0B8D0")]
		private \u0081{oGdwC ijSMnQg()
		{
			return null;
		}

		// Token: 0x0600EB1D RID: 60189 RVA: 0x00042840 File Offset: 0x00040A40
		[Token(Token = "0x600EB1D")]
		[Address(RVA = "0x13178D4", Offset = "0x13178D4", VA = "0x7BBBB178D4")]
		public int GetWeaponZoomAmplifier()
		{
			return 0;
		}

		// Token: 0x0600EB1E RID: 60190 RVA: 0x00042858 File Offset: 0x00040A58
		[Token(Token = "0x600EB1E")]
		[Address(RVA = "0x1308818", Offset = "0x1308818", VA = "0x7BBBB08818")]
		private Vector3 h^DLMT{()
		{
			return default(Vector3);
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x00042870 File Offset: 0x00040A70
		[Token(Token = "0x600EB1F")]
		[Address(RVA = "0x1317930", Offset = "0x1317930", VA = "0x7BBBB17930", Slot = "151")]
		public virtual bool RequestRescureTarget({QAb\u0082~u VT`lIxO)
		{
			return default(bool);
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x00042888 File Offset: 0x00040A88
		[Token(Token = "0x600EB20")]
		[Address(RVA = "0x1317B80", Offset = "0x1317B80", VA = "0x7BBBB17B80", Slot = "152")]
		public virtual bool RequestStopResure()
		{
			return default(bool);
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB21")]
		[Address(RVA = "0x1317BD0", Offset = "0x1317BD0", VA = "0x7BBBB17BD0")]
		protected void WRlY\u0081\u0080N()
		{
		}

		// Token: 0x0600EB22 RID: 60194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB22")]
		[Address(RVA = "0x1317C80", Offset = "0x1317C80", VA = "0x7BBBB17C80")]
		public void RequestUseTeleportDoor(uint IbUpEoU)
		{
		}

		// Token: 0x0600EB23 RID: 60195 RVA: 0x000428A0 File Offset: 0x00040AA0
		[Token(Token = "0x600EB23")]
		[Address(RVA = "0x1318560", Offset = "0x1318560", VA = "0x7BBBB18560")]
		private ResourceID Do}fnVf(BJemBU\u0080 PyEIVka)
		{
			return default(ResourceID);
		}

		// Token: 0x0600EB24 RID: 60196 RVA: 0x000428B8 File Offset: 0x00040AB8
		[Token(Token = "0x600EB24")]
		[Address(RVA = "0x13182FC", Offset = "0x13182FC", VA = "0x7BBBB182FC")]
		public bool CheckCanUseTeleportDoor()
		{
			return default(bool);
		}

		// Token: 0x0600EB25 RID: 60197 RVA: 0x000428D0 File Offset: 0x00040AD0
		[Token(Token = "0x600EB25")]
		[Address(RVA = "0x1318624", Offset = "0x1318624", VA = "0x7BBBB18624")]
		public bool CheckCanUseFerrisWheel()
		{
			return default(bool);
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x0600EB26 RID: 60198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001061")]
		public BaseLevelObject oNlhASy
		{
			[Token(Token = "0x600EB26")]
			[Address(RVA = "0x13188BC", Offset = "0x13188BC", VA = "0x7BBBB188BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB27")]
		[Address(RVA = "0x13188C4", Offset = "0x13188C4", VA = "0x7BBBB188C4", Slot = "153")]
		public virtual void RequestPlayEmote4Plant(aZ ulZd\u0081oC, uint IbUpEoU)
		{
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB28")]
		[Address(RVA = "0x1318BAC", Offset = "0x1318BAC", VA = "0x7BBBB18BAC", Slot = "154")]
		public virtual void RequestStopEmote4Plant()
		{
		}

		// Token: 0x0600EB29 RID: 60201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB29")]
		[Address(RVA = "0x1318BBC", Offset = "0x1318BBC", VA = "0x7BBBB18BBC", Slot = "155")]
		public virtual void StopPlayEmotion()
		{
		}

		// Token: 0x0600EB2A RID: 60202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB2A")]
		[Address(RVA = "0x1318C44", Offset = "0x1318C44", VA = "0x7BBBB18C44", Slot = "156")]
		public virtual void RequestSyncStopEmotion(bool f}ffd\u007F{ = false)
		{
		}

		// Token: 0x0600EB2B RID: 60203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB2B")]
		[Address(RVA = "0x1318CFC", Offset = "0x1318CFC", VA = "0x7BBBB18CFC", Slot = "157")]
		public virtual void StopEmote4Plant()
		{
		}

		// Token: 0x0600EB2C RID: 60204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB2C")]
		[Address(RVA = "0x1318D88", Offset = "0x1318D88", VA = "0x7BBBB18D88", Slot = "158")]
		public virtual void RequestOpenRangeShop(uint IbUpEoU)
		{
		}

		// Token: 0x0600EB2D RID: 60205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB2D")]
		[Address(RVA = "0x1318FD8", Offset = "0x1318FD8", VA = "0x7BBBB18FD8", Slot = "159")]
		public virtual void RequestPray4EscortBoss(uint IbUpEoU)
		{
		}

		// Token: 0x0600EB2E RID: 60206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB2E")]
		[Address(RVA = "0x131931C", Offset = "0x131931C", VA = "0x7BBBB1931C", Slot = "160")]
		public virtual void RequestStopPraying4EscortBoss()
		{
		}

		// Token: 0x0600EB2F RID: 60207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB2F")]
		[Address(RVA = "0x1319320", Offset = "0x1319320", VA = "0x7BBBB19320", Slot = "161")]
		public virtual void OnEscortBossStatusChanged()
		{
		}

		// Token: 0x0600EB30 RID: 60208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB30")]
		[Address(RVA = "0x131949C", Offset = "0x131949C", VA = "0x7BBBB1949C", Slot = "162")]
		public virtual void RequestGetOnFerrisWheel()
		{
		}

		// Token: 0x0600EB31 RID: 60209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB31")]
		[Address(RVA = "0x131980C", Offset = "0x131980C", VA = "0x7BBBB1980C", Slot = "163")]
		public virtual void RequestGetOffFerrisWheel()
		{
		}

		// Token: 0x0600EB32 RID: 60210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB32")]
		[Address(RVA = "0x1319A94", Offset = "0x1319A94", VA = "0x7BBBB19A94")]
		public void RequestEnterServerMiniGame(uint MPQ]Apr)
		{
		}

		// Token: 0x0600EB33 RID: 60211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB33")]
		[Address(RVA = "0x1319C04", Offset = "0x1319C04", VA = "0x7BBBB19C04", Slot = "164")]
		public virtual void DoUpdateActionState(EAcationState VwJDc\u007FS, EPreparationTimerType lL\u0080RNer, float LR{cUe\u0080)
		{
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB34")]
		[Address(RVA = "0x1319C08", Offset = "0x1319C08", VA = "0x7BBBB19C08")]
		public void MountWeaponGameObject(ytMNhlw ~~\u0080gGPa, string EIerWJ], float wXN]Cdx = 0f)
		{
		}

		// Token: 0x0600EB35 RID: 60213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB35")]
		[Address(RVA = "0x131A240", Offset = "0x131A240", VA = "0x7BBBB1A240")]
		public void MountWeaponGameObject(ytMNhlw ~~\u0080gGPa)
		{
		}

		// Token: 0x0600EB36 RID: 60214 RVA: 0x000428E8 File Offset: 0x00040AE8
		[Token(Token = "0x600EB36")]
		[Address(RVA = "0x1309734", Offset = "0x1309734", VA = "0x7BBBB09734")]
		public bool IsFreeMove()
		{
			return default(bool);
		}

		// Token: 0x0600EB37 RID: 60215 RVA: 0x00042900 File Offset: 0x00040B00
		[Token(Token = "0x600EB37")]
		[Address(RVA = "0x12CC578", Offset = "0x12CC578", VA = "0x7BBBACC578")]
		public bool IsFiring()
		{
			return default(bool);
		}

		// Token: 0x0600EB38 RID: 60216 RVA: 0x00042918 File Offset: 0x00040B18
		[Token(Token = "0x600EB38")]
		[Address(RVA = "0x131A72C", Offset = "0x131A72C", VA = "0x7BBBB1A72C")]
		public bool IsHoldingFireForSingleShot()
		{
			return default(bool);
		}

		// Token: 0x0600EB39 RID: 60217 RVA: 0x00042930 File Offset: 0x00040B30
		[Token(Token = "0x600EB39")]
		[Address(RVA = "0x131A77C", Offset = "0x131A77C", VA = "0x7BBBB1A77C")]
		public bool IsSniperPullingBolt()
		{
			return default(bool);
		}

		// Token: 0x0600EB3A RID: 60218 RVA: 0x00042948 File Offset: 0x00040B48
		[Token(Token = "0x600EB3A")]
		[Address(RVA = "0x131A7CC", Offset = "0x131A7CC", VA = "0x7BBBB1A7CC")]
		public ytMNhlw.Utan}]\u0081 GetWeaponType()
		{
			return ytMNhlw.Utan}]\u0081.Rifle;
		}

		// Token: 0x0600EB3B RID: 60219 RVA: 0x00042960 File Offset: 0x00040B60
		[Token(Token = "0x600EB3B")]
		[Address(RVA = "0x131A84C", Offset = "0x131A84C", VA = "0x7BBBB1A84C")]
		public int GetWeaponSubType()
		{
			return 0;
		}

		// Token: 0x0600EB3C RID: 60220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB3C")]
		[Address(RVA = "0x131A8CC", Offset = "0x131A8CC", VA = "0x7BBBB1A8CC")]
		protected void FZgn\u0080\u0081n(bool y]nw`{J = true)
		{
		}

		// Token: 0x0600EB3D RID: 60221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB3D")]
		[Address(RVA = "0x131A9C4", Offset = "0x131A9C4", VA = "0x7BBBB1A9C4")]
		private void [\u0081cthpz(bool gvJUmod)
		{
		}

		// Token: 0x0600EB3E RID: 60222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB3E")]
		[Address(RVA = "0x131AC38", Offset = "0x131AC38", VA = "0x7BBBB1AC38", Slot = "165")]
		public virtual void OnGetOnFerrisWheel(LevelFerrisWheel \u0080frKI|], byte pLk[NEu, byte V|VEcZZ)
		{
		}

		// Token: 0x0600EB3F RID: 60223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB3F")]
		[Address(RVA = "0x131ADD4", Offset = "0x131ADD4", VA = "0x7BBBB1ADD4", Slot = "166")]
		public virtual void OnGetOffFerrisWheel(byte pLk[NEu, byte V|VEcZZ)
		{
		}

		// Token: 0x0600EB40 RID: 60224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB40")]
		[Address(RVA = "0x131AF28", Offset = "0x131AF28", VA = "0x7BBBB1AF28")]
		protected void \u007FrcBDad()
		{
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB41")]
		[Address(RVA = "0x131B054", Offset = "0x131B054", VA = "0x7BBBB1B054", Slot = "167")]
		public virtual void OnGetOnVehicle(Vehicle lyabLZX)
		{
		}

		// Token: 0x0600EB42 RID: 60226 RVA: 0x00042978 File Offset: 0x00040B78
		[Token(Token = "0x600EB42")]
		[Address(RVA = "0x131BC58", Offset = "0x131BC58", VA = "0x7BBBB1BC58")]
		public Vector3 GetOffVehiclePosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB43")]
		[Address(RVA = "0x131CDDC", Offset = "0x131CDDC", VA = "0x7BBBB1CDDC", Slot = "168")]
		public virtual void OnGetOffVehicle()
		{
		}

		// Token: 0x0600EB44 RID: 60228 RVA: 0x00042990 File Offset: 0x00040B90
		[Token(Token = "0x600EB44")]
		[Address(RVA = "0x131D890", Offset = "0x131D890", VA = "0x7BBBB1D890")]
		public bool GetOnStropPrecheck()
		{
			return default(bool);
		}

		// Token: 0x0600EB45 RID: 60229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB45")]
		[Address(RVA = "0x131DAC8", Offset = "0x131DAC8", VA = "0x7BBBB1DAC8", Slot = "169")]
		public virtual void OnGetOnStrop(LevelStrop yM\u007FRbr\u0081, float vCMtXQG)
		{
		}

		// Token: 0x0600EB46 RID: 60230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB46")]
		[Address(RVA = "0x131EA4C", Offset = "0x131EA4C", VA = "0x7BBBB1EA4C", Slot = "170")]
		public virtual void OnGetOffStrop(float \u007F]ucXcr)
		{
		}

		// Token: 0x0600EB47 RID: 60231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB47")]
		[Address(RVA = "0x131EEB8", Offset = "0x131EEB8", VA = "0x7BBBB1EEB8")]
		private void ceGCLcd()
		{
		}

		// Token: 0x0600EB48 RID: 60232 RVA: 0x000429A8 File Offset: 0x00040BA8
		[Token(Token = "0x600EB48")]
		[Address(RVA = "0x131F0F4", Offset = "0x131F0F4", VA = "0x7BBBB1F0F4", Slot = "72")]
		public bool HasGrapplingHook()
		{
			return default(bool);
		}

		// Token: 0x0600EB49 RID: 60233 RVA: 0x000429C0 File Offset: 0x00040BC0
		[Token(Token = "0x600EB49")]
		[Address(RVA = "0x131F1A8", Offset = "0x131F1A8", VA = "0x7BBBB1F1A8", Slot = "74")]
		public bool HasVMEHook()
		{
			return default(bool);
		}

		// Token: 0x0600EB4A RID: 60234 RVA: 0x000429D8 File Offset: 0x00040BD8
		[Token(Token = "0x600EB4A")]
		[Address(RVA = "0x12ECC34", Offset = "0x12ECC34", VA = "0x7BBBAECC34", Slot = "73")]
		public bool HasHook()
		{
			return default(bool);
		}

		// Token: 0x0600EB4B RID: 60235 RVA: 0x000429F0 File Offset: 0x00040BF0
		[Token(Token = "0x600EB4B")]
		[Address(RVA = "0x131F25C", Offset = "0x131F25C", VA = "0x7BBBB1F25C", Slot = "69")]
		public bool IsOnGrapplingHook()
		{
			return default(bool);
		}

		// Token: 0x0600EB4C RID: 60236 RVA: 0x00042A08 File Offset: 0x00040C08
		[Token(Token = "0x600EB4C")]
		[Address(RVA = "0x12F9204", Offset = "0x12F9204", VA = "0x7BBBAF9204", Slot = "70")]
		public bool IsOnHook()
		{
			return default(bool);
		}

		// Token: 0x0600EB4D RID: 60237 RVA: 0x00042A20 File Offset: 0x00040C20
		[Token(Token = "0x600EB4D")]
		[Address(RVA = "0x131F2AC", Offset = "0x131F2AC", VA = "0x7BBBB1F2AC", Slot = "71")]
		public bool IsOnVMEHook()
		{
			return default(bool);
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB4E")]
		[Address(RVA = "0x131F2FC", Offset = "0x131F2FC", VA = "0x7BBBB1F2FC")]
		public void OnGrapplingHookSpawned(LevelGrapplingHook RemB|ud)
		{
		}

		// Token: 0x0600EB4F RID: 60239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB4F")]
		[Address(RVA = "0x131F304", Offset = "0x131F304", VA = "0x7BBBB1F304")]
		public void OnGrapplingHookHooked()
		{
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x0600EB50 RID: 60240 RVA: 0x00042A38 File Offset: 0x00040C38
		// (set) Token: 0x0600EB51 RID: 60241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001062")]
		public bool {zuCQN\u0080
		{
			[Token(Token = "0x600EB50")]
			[Address(RVA = "0x131F31C", Offset = "0x131F31C", VA = "0x7BBBB1F31C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A624", Offset = "0x114A624")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EB51")]
			[Address(RVA = "0x131F324", Offset = "0x131F324", VA = "0x7BBBB1F324")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A634", Offset = "0x114A634")]
			set
			{
			}
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB52")]
		[Address(RVA = "0x12ECCA4", Offset = "0x12ECCA4", VA = "0x7BBBAECCA4")]
		public void OnGrapplingHookDestroyed()
		{
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB53")]
		[Address(RVA = "0x131F330", Offset = "0x131F330", VA = "0x7BBBB1F330")]
		public void GetOffGrapplingHook()
		{
		}

		// Token: 0x0600EB54 RID: 60244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB54")]
		[Address(RVA = "0x131F378", Offset = "0x131F378", VA = "0x7BBBB1F378")]
		public void OnGrapplingHookReEnter(Vector3 WZiTJ\u0080|)
		{
		}

		// Token: 0x0600EB55 RID: 60245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB55")]
		[Address(RVA = "0x131F3FC", Offset = "0x131F3FC", VA = "0x7BBBB1F3FC")]
		public void StartOnGrapplingHook()
		{
		}

		// Token: 0x0600EB56 RID: 60246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB56")]
		[Address(RVA = "0x131F844", Offset = "0x131F844", VA = "0x7BBBB1F844")]
		public void StopOnGrapplingHook()
		{
		}

		// Token: 0x0600EB57 RID: 60247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB57")]
		[Address(RVA = "0x12E5104", Offset = "0x12E5104", VA = "0x7BBBAE5104")]
		private void jcFfGVA()
		{
		}

		// Token: 0x0600EB58 RID: 60248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB58")]
		[Address(RVA = "0x131FAE0", Offset = "0x131FAE0", VA = "0x7BBBB1FAE0")]
		public void AddWeaponImpactEffectToPool(ResourceID aM|nVWY, GameObject gIyvwRk)
		{
		}

		// Token: 0x0600EB59 RID: 60249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB59")]
		[Address(RVA = "0x131FC90", Offset = "0x131FC90", VA = "0x7BBBB1FC90", Slot = "85")]
		public void OnReusableObjectRecycled(ResourceID \u0081NfZQFg, GameObject gIyvwRk)
		{
		}

		// Token: 0x0600EB5A RID: 60250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB5A")]
		[Address(RVA = "0x12E699C", Offset = "0x12E699C", VA = "0x7BBBAE699C")]
		private void P\u0081tuGnZ()
		{
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB5B")]
		[Address(RVA = "0x12E6B18", Offset = "0x12E6B18", VA = "0x7BBBAE6B18")]
		private void m]HlB}O()
		{
		}

		// Token: 0x0600EB5C RID: 60252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB5C")]
		[Address(RVA = "0x131FDA4", Offset = "0x131FDA4", VA = "0x7BBBB1FDA4")]
		public void StartJumpOffStrop(bool |jZqWbw)
		{
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x00042A50 File Offset: 0x00040C50
		[Token(Token = "0x600EB5D")]
		[Address(RVA = "0x1318880", Offset = "0x1318880", VA = "0x7BBBB18880")]
		public bool IsFalling()
		{
			return default(bool);
		}

		// Token: 0x0600EB5E RID: 60254 RVA: 0x00042A68 File Offset: 0x00040C68
		[Token(Token = "0x600EB5E")]
		[Address(RVA = "0x12D19FC", Offset = "0x12D19FC", VA = "0x7BBBAD19FC", Slot = "66")]
		public bool IsOnStrop()
		{
			return default(bool);
		}

		// Token: 0x0600EB5F RID: 60255 RVA: 0x00042A80 File Offset: 0x00040C80
		[Token(Token = "0x600EB5F")]
		[Address(RVA = "0x12CE110", Offset = "0x12CE110", VA = "0x7BBBACE110", Slot = "67")]
		public bool IsOnChair()
		{
			return default(bool);
		}

		// Token: 0x0600EB60 RID: 60256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB60")]
		[Address(RVA = "0x1320084", Offset = "0x1320084", VA = "0x7BBBB20084")]
		public FerrisWheelSeatGroup GetFerrisTriggerIAmIn()
		{
			return null;
		}

		// Token: 0x0600EB61 RID: 60257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB61")]
		[Address(RVA = "0x132008C", Offset = "0x132008C", VA = "0x7BBBB2008C", Slot = "75")]
		public LevelStrop GetStropIAmOn()
		{
			return null;
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x00042A98 File Offset: 0x00040C98
		[Token(Token = "0x600EB62")]
		[Address(RVA = "0x12CA7D4", Offset = "0x12CA7D4", VA = "0x7BBBACA7D4", Slot = "63")]
		public bool IsInVehicle()
		{
			return default(bool);
		}

		// Token: 0x0600EB63 RID: 60259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB63")]
		[Address(RVA = "0x12E42E4", Offset = "0x12E42E4", VA = "0x7BBBAE42E4")]
		public Vehicle GetVehicleIAmIn()
		{
			return null;
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB64")]
		[Address(RVA = "0x1320094", Offset = "0x1320094", VA = "0x7BBBB20094")]
		public void ApplyVechileControl(eychyvP cWdBgU\u007F, Vector3 HIDbVsf)
		{
		}

		// Token: 0x0600EB65 RID: 60261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB65")]
		[Address(RVA = "0x12CD6A0", Offset = "0x12CD6A0", VA = "0x7BBBACD6A0")]
		public void PlayAshot(ResourceID {NRR\u0081yd, bool wq[g~tk = true, float Ah^hMIX = 1f, [Optional] ResourceID YPSuWsy, bool JxflwfT = false, EAudioEngineType vdAqjUp = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x0600EB66 RID: 60262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB66")]
		[Address(RVA = "0x1320214", Offset = "0x1320214", VA = "0x7BBBB20214", Slot = "60")]
		public List<Vector3> GetBoundingBoxList()
		{
			return null;
		}

		// Token: 0x0600EB67 RID: 60263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB67")]
		[Address(RVA = "0x13203E4", Offset = "0x13203E4", VA = "0x7BBBB203E4", Slot = "19")]
		protected override void OnUpdateVisibleStateByStreamer(Vector3 oiL\u007Fpo|, Vector3 ONDVztx)
		{
		}

		// Token: 0x0600EB68 RID: 60264 RVA: 0x00042AB0 File Offset: 0x00040CB0
		[Token(Token = "0x600EB68")]
		[Address(RVA = "0x13204D4", Offset = "0x13204D4", VA = "0x7BBBB204D4", Slot = "55")]
		public Vector3 GetCameraTrackableEntityPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600EB69 RID: 60265 RVA: 0x00042AC8 File Offset: 0x00040CC8
		[Token(Token = "0x600EB69")]
		[Address(RVA = "0x1320508", Offset = "0x1320508", VA = "0x7BBBB20508", Slot = "57")]
		public Quaternion GetCameraTrackableEntityAimRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x0600EB6A RID: 60266 RVA: 0x00042AE0 File Offset: 0x00040CE0
		[Token(Token = "0x600EB6A")]
		[Address(RVA = "0x1305ED4", Offset = "0x1305ED4", VA = "0x7BBBB05ED4", Slot = "56")]
		public Vector3 GetCameraTrackableEntityTopPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600EB6B RID: 60267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB6B")]
		[Address(RVA = "0x1320564", Offset = "0x1320564", VA = "0x7BBBB20564", Slot = "58")]
		public Transform GetCameraTrackableEntityTransfrom()
		{
			return null;
		}

		// Token: 0x0600EB6C RID: 60268 RVA: 0x00042AF8 File Offset: 0x00040CF8
		[Token(Token = "0x600EB6C")]
		[Address(RVA = "0x132056C", Offset = "0x132056C", VA = "0x7BBBB2056C", Slot = "59")]
		public bool IsCameraTrackableEntityAlive()
		{
			return default(bool);
		}

		// Token: 0x0600EB6D RID: 60269 RVA: 0x00042B10 File Offset: 0x00040D10
		[Token(Token = "0x600EB6D")]
		[Address(RVA = "0x1320688", Offset = "0x1320688", VA = "0x7BBBB20688", Slot = "171")]
		public virtual bool IsOutOfControl()
		{
			return default(bool);
		}

		// Token: 0x0600EB6E RID: 60270 RVA: 0x00042B28 File Offset: 0x00040D28
		[Token(Token = "0x600EB6E")]
		[Address(RVA = "0x13206D4", Offset = "0x13206D4", VA = "0x7BBBB206D4", Slot = "172")]
		public virtual bool NeedTickWhenDead()
		{
			return default(bool);
		}

		// Token: 0x0600EB6F RID: 60271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB6F")]
		[Address(RVA = "0x13206E4", Offset = "0x13206E4", VA = "0x7BBBB206E4")]
		public void SetDriverSteeringAngle(float tjREevq)
		{
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB70")]
		[Address(RVA = "0x1320748", Offset = "0x1320748", VA = "0x7BBBB20748")]
		public void SetHasDriverForAim(float tjREevq)
		{
		}

		// Token: 0x0600EB71 RID: 60273 RVA: 0x00042B40 File Offset: 0x00040D40
		[Token(Token = "0x600EB71")]
		[Address(RVA = "0x13207AC", Offset = "0x13207AC", VA = "0x7BBBB207AC")]
		private ResourceID [G}ZUQN()
		{
			return default(ResourceID);
		}

		// Token: 0x0600EB72 RID: 60274 RVA: 0x00042B58 File Offset: 0x00040D58
		[Token(Token = "0x600EB72")]
		[Address(RVA = "0x13208D8", Offset = "0x13208D8", VA = "0x7BBBB208D8")]
		public bool HasCustomAnimation()
		{
			return default(bool);
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x0600EB73 RID: 60275 RVA: 0x00042B70 File Offset: 0x00040D70
		[Token(Token = "0x17001063")]
		public bool vkYwJSy
		{
			[Token(Token = "0x600EB73")]
			[Address(RVA = "0x12FD010", Offset = "0x12FD010", VA = "0x7BBBAFD010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x0600EB74 RID: 60276 RVA: 0x00042B88 File Offset: 0x00040D88
		[Token(Token = "0x17001064")]
		public bool u~SrCh\u0081
		{
			[Token(Token = "0x600EB74")]
			[Address(RVA = "0x132095C", Offset = "0x132095C", VA = "0x7BBBB2095C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600EB75 RID: 60277 RVA: 0x00042BA0 File Offset: 0x00040DA0
		[Token(Token = "0x17001065")]
		public bool EA]vhx^
		{
			[Token(Token = "0x600EB75")]
			[Address(RVA = "0x13209E4", Offset = "0x13209E4", VA = "0x7BBBB209E4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x0600EB76 RID: 60278 RVA: 0x00042BB8 File Offset: 0x00040DB8
		[Token(Token = "0x17001066")]
		public bool G[evcr~
		{
			[Token(Token = "0x600EB76")]
			[Address(RVA = "0x1308280", Offset = "0x1308280", VA = "0x7BBBB08280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EB77 RID: 60279 RVA: 0x00042BD0 File Offset: 0x00040DD0
		[Token(Token = "0x600EB77")]
		[Address(RVA = "0x1320AD0", Offset = "0x1320AD0", VA = "0x7BBBB20AD0", Slot = "173")]
		public virtual bool RequestPlayCustomAnimation()
		{
			return default(bool);
		}

		// Token: 0x0600EB78 RID: 60280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB78")]
		[Address(RVA = "0x12CD3F8", Offset = "0x12CD3F8", VA = "0x7BBBACD3F8")]
		public void SpawnBattleFlagOnHand()
		{
		}

		// Token: 0x0600EB79 RID: 60281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB79")]
		[Address(RVA = "0x132105C", Offset = "0x132105C", VA = "0x7BBBB2105C")]
		protected void RfQmLNL()
		{
		}

		// Token: 0x0600EB7A RID: 60282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB7A")]
		[Address(RVA = "0x1310FF8", Offset = "0x1310FF8", VA = "0x7BBBB10FF8")]
		protected void DmlsEU~()
		{
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x00042BE8 File Offset: 0x00040DE8
		[Token(Token = "0x600EB7B")]
		[Address(RVA = "0x1321338", Offset = "0x1321338", VA = "0x7BBBB21338")]
		protected Vector3 pCl\u0082D|b()
		{
			return default(Vector3);
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB7C")]
		[Address(RVA = "0x13214E0", Offset = "0x13214E0", VA = "0x7BBBB214E0")]
		public GameObject GetBattleFlagOnGround()
		{
			return null;
		}

		// Token: 0x0600EB7D RID: 60285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB7D")]
		[Address(RVA = "0x1321510", Offset = "0x1321510", VA = "0x7BBBB21510")]
		public void ClearOnGroundBattleFlagRef()
		{
		}

		// Token: 0x0600EB7E RID: 60286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB7E")]
		[Address(RVA = "0x12CCF90", Offset = "0x12CCF90", VA = "0x7BBBACCF90")]
		public void ChangedBattleFlagToGround()
		{
		}

		// Token: 0x0600EB7F RID: 60287 RVA: 0x00042C00 File Offset: 0x00040E00
		[Token(Token = "0x600EB7F")]
		[Address(RVA = "0x1321518", Offset = "0x1321518", VA = "0x7BBBB21518", Slot = "174")]
		public virtual bool RequestUseBattleFlag()
		{
			return default(bool);
		}

		// Token: 0x0600EB80 RID: 60288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB80")]
		[Address(RVA = "0x132159C", Offset = "0x132159C", VA = "0x7BBBB2159C")]
		protected void GIvMyTl()
		{
		}

		// Token: 0x0600EB81 RID: 60289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB81")]
		[Address(RVA = "0x1311120", Offset = "0x1311120", VA = "0x7BBBB11120")]
		private void iS}sdzw()
		{
		}

		// Token: 0x0600EB82 RID: 60290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB82")]
		[Address(RVA = "0x12CF700", Offset = "0x12CF700", VA = "0x7BBBACF700")]
		public void StopAnimEfects(bool STeFCg| = false)
		{
		}

		// Token: 0x0600EB83 RID: 60291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB83")]
		[Address(RVA = "0x132167C", Offset = "0x132167C", VA = "0x7BBBB2167C")]
		public void ResetClothEffectEmoteShowMaskVisibility()
		{
		}

		// Token: 0x0600EB84 RID: 60292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB84")]
		[Address(RVA = "0x1320D08", Offset = "0x1320D08", VA = "0x7BBBB20D08")]
		public void PlayCustomAnimation(sbyte OSvO{nh = 0)
		{
		}

		// Token: 0x0600EB85 RID: 60293 RVA: 0x00042C18 File Offset: 0x00040E18
		[Token(Token = "0x600EB85")]
		[Address(RVA = "0x132194C", Offset = "0x132194C", VA = "0x7BBBB2194C", Slot = "175")]
		public virtual bool RequestPlayEmotionAnimation(uint ItXfeh^ = 1U, float }ugMGwi = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600EB86 RID: 60294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB86")]
		[Address(RVA = "0x1321EE8", Offset = "0x1321EE8", VA = "0x7BBBB21EE8")]
		public void PlayAnimation(ResourceID ^`QEUlJ)
		{
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB87")]
		[Address(RVA = "0x1321F54", Offset = "0x1321F54", VA = "0x7BBBB21F54")]
		public void UpdateBuffBehaivor(SmiCE\u007FC ~S`Xinb)
		{
		}

		// Token: 0x0600EB88 RID: 60296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB88")]
		[Address(RVA = "0x1323EC0", Offset = "0x1323EC0", VA = "0x7BBBB23EC0")]
		private void gw\u007FLxAQ(bool wCGPJzg)
		{
		}

		// Token: 0x0600EB89 RID: 60297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB89")]
		[Address(RVA = "0x1321BC8", Offset = "0x1321BC8", VA = "0x7BBBB21BC8")]
		public void PlayEmotionAnimation(uint ItXfeh^, float }ugMGwi = 0f)
		{
		}

		// Token: 0x0600EB8A RID: 60298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB8A")]
		[Address(RVA = "0x1324054", Offset = "0x1324054", VA = "0x7BBBB24054")]
		public void LeadEmote(uint ^mytTwB)
		{
		}

		// Token: 0x0600EB8B RID: 60299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB8B")]
		[Address(RVA = "0x13242FC", Offset = "0x13242FC", VA = "0x7BBBB242FC")]
		public void FollowEmote({QAb\u0082~u mB[J}YY)
		{
		}

		// Token: 0x0600EB8C RID: 60300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB8C")]
		[Address(RVA = "0x1321718", Offset = "0x1321718", VA = "0x7BBBB21718")]
		private void qx\u0081|Hhm()
		{
		}

		// Token: 0x0600EB8D RID: 60301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB8D")]
		[Address(RVA = "0x12F2E64", Offset = "0x12F2E64", VA = "0x7BBBAF2E64")]
		private void p|}cNIE(LevelDoor JW{jS{q)
		{
		}

		// Token: 0x0600EB8E RID: 60302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB8E")]
		[Address(RVA = "0x12F9254", Offset = "0x12F9254", VA = "0x7BBBAF9254")]
		private void bSJrMs[(LevelDoor JW{jS{q)
		{
		}

		// Token: 0x0600EB8F RID: 60303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB8F")]
		[Address(RVA = "0x12F7FC0", Offset = "0x12F7FC0", VA = "0x7BBBAF7FC0")]
		private void g{(LevelDoor JW{jS{q)
		{
		}

		// Token: 0x0600EB90 RID: 60304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB90")]
		[Address(RVA = "0x13244F4", Offset = "0x13244F4", VA = "0x7BBBB244F4")]
		public void SetExternalWeapon(mMxsv\u0080C |BbeZ[~)
		{
		}

		// Token: 0x0600EB91 RID: 60305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB91")]
		[Address(RVA = "0x130E6C4", Offset = "0x130E6C4", VA = "0x7BBBB0E6C4")]
		public H\u0080}KEpn GetCombinedWeapon()
		{
			return null;
		}

		// Token: 0x0600EB92 RID: 60306 RVA: 0x00042C30 File Offset: 0x00040E30
		[Token(Token = "0x600EB92")]
		[Address(RVA = "0x132455C", Offset = "0x132455C", VA = "0x7BBBB2455C")]
		public bool CanCombineWeapon()
		{
			return default(bool);
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB93")]
		[Address(RVA = "0x12E92B0", Offset = "0x12E92B0", VA = "0x7BBBAE92B0")]
		protected void l~c{Co^(int EmJdfCs)
		{
		}

		// Token: 0x0600EB94 RID: 60308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB94")]
		[Address(RVA = "0x12E690C", Offset = "0x12E690C", VA = "0x7BBBAE690C")]
		protected GameObject CPFez\u0082X()
		{
			return null;
		}

		// Token: 0x0600EB95 RID: 60309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB95")]
		[Address(RVA = "0x132458C", Offset = "0x132458C", VA = "0x7BBBB2458C")]
		protected void ]vuBFSv(int tgAKrr])
		{
		}

		// Token: 0x0600EB96 RID: 60310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB96")]
		[Address(RVA = "0x1324BA4", Offset = "0x1324BA4", VA = "0x7BBBB24BA4")]
		protected void H}YS[ej(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600EB97 RID: 60311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB97")]
		[Address(RVA = "0x1324EDC", Offset = "0x1324EDC", VA = "0x7BBBB24EDC")]
		protected void PUEiq\u007Fx(^\u0080GY\u007Fzh.b\u0080OrFRT [kySBRy, int EmJdfCs)
		{
		}

		// Token: 0x0600EB98 RID: 60312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB98")]
		[Address(RVA = "0x13250B0", Offset = "0x13250B0", VA = "0x7BBBB250B0")]
		protected void KmukYEJ(int EmJdfCs)
		{
		}

		// Token: 0x0600EB99 RID: 60313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB99")]
		[Address(RVA = "0x13253CC", Offset = "0x13253CC", VA = "0x7BBBB253CC", Slot = "176")]
		public virtual void PlayBigHeadHypeEffect()
		{
		}

		// Token: 0x0600EB9A RID: 60314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB9A")]
		[Address(RVA = "0x13253D8", Offset = "0x13253D8", VA = "0x7BBBB253D8")]
		private void [Suwamq()
		{
		}

		// Token: 0x0600EB9B RID: 60315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB9B")]
		[Address(RVA = "0x13256A0", Offset = "0x13256A0", VA = "0x7BBBB256A0")]
		public void PlaySwimmingSurfSound(bool uQOjozV)
		{
		}

		// Token: 0x0600EB9C RID: 60316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB9C")]
		[Address(RVA = "0x132582C", Offset = "0x132582C", VA = "0x7BBBB2582C")]
		public void PlaySurfEffect(ResourceID hM{K{hH)
		{
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB9D")]
		[Address(RVA = "0x1325A4C", Offset = "0x1325A4C", VA = "0x7BBBB25A4C")]
		public void DelayEquipBoard()
		{
		}

		// Token: 0x0600EB9E RID: 60318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB9E")]
		[Address(RVA = "0x1325AF4", Offset = "0x1325AF4", VA = "0x7BBBB25AF4")]
		public void StopEquipBoardCoroutine()
		{
		}

		// Token: 0x0600EB9F RID: 60319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB9F")]
		[Address(RVA = "0x1325A80", Offset = "0x1325A80", VA = "0x7BBBB25A80")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114A644", Offset = "0x114A644")]
		private IEnumerator t[nz~nI()
		{
			return null;
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBA0")]
		[Address(RVA = "0x1325B28", Offset = "0x1325B28", VA = "0x7BBBB25B28")]
		public void StartCheckBooyahEmote()
		{
		}

		// Token: 0x0600EBA1 RID: 60321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBA1")]
		[Address(RVA = "0x12CED20", Offset = "0x12CED20", VA = "0x7BBBACED20")]
		public void StopCheckBooyahEmote(bool MLXks\u0080g = true)
		{
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EBA2")]
		[Address(RVA = "0x1325BC4", Offset = "0x1325BC4", VA = "0x7BBBB25BC4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114A6A8", Offset = "0x114A6A8")]
		private IEnumerator AY\u0080Fpjw()
		{
			return null;
		}

		// Token: 0x0600EBA3 RID: 60323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBA3")]
		[Address(RVA = "0x1325C38", Offset = "0x1325C38", VA = "0x7BBBB25C38")]
		public void SetObservered(bool UOhq{XI)
		{
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x0600EBA4 RID: 60324 RVA: 0x00042C48 File Offset: 0x00040E48
		[Token(Token = "0x17001067")]
		public int UdmhTC\u007F
		{
			[Token(Token = "0x600EBA4")]
			[Address(RVA = "0x1325D18", Offset = "0x1325D18", VA = "0x7BBBB25D18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600EBA5 RID: 60325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBA5")]
		[Address(RVA = "0x1325D20", Offset = "0x1325D20", VA = "0x7BBBB25D20")]
		public void UsedRedEnvelope()
		{
		}

		// Token: 0x0600EBA6 RID: 60326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBA6")]
		[Address(RVA = "0x12F3028", Offset = "0x12F3028", VA = "0x7BBBAF3028")]
		public void OnEnterDamageZone(LevelDamageZone RRuvSsa)
		{
		}

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBA7")]
		[Address(RVA = "0x12F8150", Offset = "0x12F8150", VA = "0x7BBBAF8150")]
		public void OnExitDamageZone(LevelDamageZone RRuvSsa)
		{
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x0600EBA8 RID: 60328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001068")]
		public Player ]~m^~G\u0080
		{
			[Token(Token = "0x600EBA8")]
			[Address(RVA = "0x1325D30", Offset = "0x1325D30", VA = "0x7BBBB25D30", Slot = "84")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EBA9 RID: 60329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBA9")]
		[Address(RVA = "0x1325D34", Offset = "0x1325D34", VA = "0x7BBBB25D34")]
		public void SetVehicleVisible()
		{
		}

		// Token: 0x0600EBAA RID: 60330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBAA")]
		[Address(RVA = "0x1325D4C", Offset = "0x1325D4C", VA = "0x7BBBB25D4C")]
		public void DebugPlayerVisibilityInfo()
		{
		}

		// Token: 0x0600EBAB RID: 60331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBAB")]
		[Address(RVA = "0x1325FA0", Offset = "0x1325FA0", VA = "0x7BBBB25FA0")]
		public void StartPendingRevive(uint yndbRHH)
		{
		}

		// Token: 0x0600EBAC RID: 60332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBAC")]
		[Address(RVA = "0x13263C4", Offset = "0x13263C4", VA = "0x7BBBB263C4")]
		public void StopPendingRevive(bool [uS]\u0081pX)
		{
		}

		// Token: 0x0600EBAD RID: 60333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBAD")]
		[Address(RVA = "0x1326AC0", Offset = "0x1326AC0", VA = "0x7BBBB26AC0")]
		public void ReviveInitState(Vector3 cC|iom\u007F, Quaternion laYChSW, uint vFYXyvS)
		{
		}

		// Token: 0x0600EBAE RID: 60334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBAE")]
		[Address(RVA = "0x12ECF48", Offset = "0x12ECF48", VA = "0x7BBBAECF48")]
		protected void Ss\u0081tNsR()
		{
		}

		// Token: 0x0600EBAF RID: 60335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBAF")]
		[Address(RVA = "0x1326DAC", Offset = "0x1326DAC", VA = "0x7BBBB26DAC")]
		protected void IYhFGp[()
		{
		}

		// Token: 0x0600EBB0 RID: 60336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB0")]
		[Address(RVA = "0x1326ED8", Offset = "0x1326ED8", VA = "0x7BBBB26ED8", Slot = "177")]
		public virtual void ReviveInitMotionState(Vector3 cC|iom\u007F, Quaternion laYChSW, uint vFYXyvS)
		{
		}

		// Token: 0x0600EBB1 RID: 60337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB1")]
		[Address(RVA = "0x1326D4C", Offset = "0x1326D4C", VA = "0x7BBBB26D4C")]
		public void ReviveClearDamageZone()
		{
		}

		// Token: 0x0600EBB2 RID: 60338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB2")]
		[Address(RVA = "0x1327094", Offset = "0x1327094", VA = "0x7BBBB27094")]
		protected void dpcxtLg()
		{
		}

		// Token: 0x0600EBB3 RID: 60339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB3")]
		[Address(RVA = "0x13272D8", Offset = "0x13272D8", VA = "0x7BBBB272D8")]
		public void OnGetInCatapult(LevelCatapult ROp~r[w)
		{
		}

		// Token: 0x0600EBB4 RID: 60340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB4")]
		[Address(RVA = "0x12EC9AC", Offset = "0x12EC9AC", VA = "0x7BBBAEC9AC")]
		public void OnGetOutCatapult(LevelCatapult ROp~r[w)
		{
		}

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB5")]
		[Address(RVA = "0x13276B0", Offset = "0x13276B0", VA = "0x7BBBB276B0")]
		public void OnCatapultLaunch()
		{
		}

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB6")]
		[Address(RVA = "0x1327ABC", Offset = "0x1327ABC", VA = "0x7BBBB27ABC")]
		public void OnStopCatapultFalling()
		{
		}

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x00042C60 File Offset: 0x00040E60
		[Token(Token = "0x600EBB7")]
		[Address(RVA = "0x12CEE44", Offset = "0x12CEE44", VA = "0x7BBBACEE44")]
		public bool IsCatapultFalling()
		{
			return default(bool);
		}

		// Token: 0x0600EBB8 RID: 60344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB8")]
		[Address(RVA = "0x1327BC8", Offset = "0x1327BC8", VA = "0x7BBBB27BC8")]
		public void ShowCatapultFallingTailTraceLine()
		{
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBB9")]
		[Address(RVA = "0x1327D78", Offset = "0x1327D78", VA = "0x7BBBB27D78")]
		public void RemoveCatapultFallingTailTraceLine()
		{
		}

		// Token: 0x0600EBBA RID: 60346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBBA")]
		[Address(RVA = "0x13279CC", Offset = "0x13279CC", VA = "0x7BBBB279CC")]
		private void HH^pYSg()
		{
		}

		// Token: 0x0600EBBB RID: 60347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBBB")]
		[Address(RVA = "0x1327E5C", Offset = "0x1327E5C", VA = "0x7BBBB27E5C")]
		private void QVUr[bV()
		{
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x0600EBBC RID: 60348 RVA: 0x00042C78 File Offset: 0x00040E78
		// (set) Token: 0x0600EBBD RID: 60349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001069")]
		public bool Vei~\u0081XE
		{
			[Token(Token = "0x600EBBC")]
			[Address(RVA = "0x1327F20", Offset = "0x1327F20", VA = "0x7BBBB27F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EBBD")]
			[Address(RVA = "0x1327F28", Offset = "0x1327F28", VA = "0x7BBBB27F28")]
			private set
			{
			}
		}

		// Token: 0x0600EBBE RID: 60350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBBE")]
		[Address(RVA = "0x1327F34", Offset = "0x1327F34", VA = "0x7BBBB27F34")]
		public void OnGodStateCome(bool yTcR{RK, float qKJCh{y)
		{
		}

		// Token: 0x0600EBBF RID: 60351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBBF")]
		[Address(RVA = "0x13083A8", Offset = "0x13083A8", VA = "0x7BBBB083A8")]
		private void RVdNawT(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC0")]
		[Address(RVA = "0x1323DA0", Offset = "0x1323DA0", VA = "0x7BBBB23DA0")]
		private void DdQg\u0080dK()
		{
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC1")]
		[Address(RVA = "0x13281D0", Offset = "0x13281D0", VA = "0x7BBBB281D0")]
		public void PlayEffect(ResourceID aM|nVWY)
		{
		}

		// Token: 0x0600EBC2 RID: 60354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC2")]
		[Address(RVA = "0x1328414", Offset = "0x1328414", VA = "0x7BBBB28414", Slot = "178")]
		public virtual void UpdatePendingReviveState(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EBC3 RID: 60355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC3")]
		[Address(RVA = "0x12F97FC", Offset = "0x12F97FC", VA = "0x7BBBAF97FC")]
		protected void ljVYP\u0080\u0082(aZ ulZd\u0081oC, uint IbUpEoU)
		{
		}

		// Token: 0x0600EBC4 RID: 60356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC4")]
		[Address(RVA = "0x12F83F0", Offset = "0x12F83F0", VA = "0x7BBBAF83F0")]
		protected void yqkykiX(aZ ulZd\u0081oC, uint IbUpEoU)
		{
		}

		// Token: 0x0600EBC5 RID: 60357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC5")]
		[Address(RVA = "0x132847C", Offset = "0x132847C", VA = "0x7BBBB2847C")]
		protected void \u007FDlHGi](aZ ulZd\u0081oC, uint IbUpEoU, bool KZhaUNp)
		{
		}

		// Token: 0x0600EBC6 RID: 60358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC6")]
		[Address(RVA = "0x1328648", Offset = "0x1328648", VA = "0x7BBBB28648")]
		private void \u007FjFxtc\u007F(LevelChair extNxIL)
		{
		}

		// Token: 0x0600EBC7 RID: 60359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC7")]
		[Address(RVA = "0x1328828", Offset = "0x1328828", VA = "0x7BBBB28828")]
		public void OnGetOnChair(LevelChair extNxIL)
		{
		}

		// Token: 0x0600EBC8 RID: 60360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC8")]
		[Address(RVA = "0x13288F0", Offset = "0x13288F0", VA = "0x7BBBB288F0")]
		public void OnGetOffChair(LevelChair extNxIL)
		{
		}

		// Token: 0x0600EBC9 RID: 60361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC9")]
		[Address(RVA = "0x13289A8", Offset = "0x13289A8", VA = "0x7BBBB289A8")]
		protected void w[Em|Y^(Player.yyEoKfi \u0082Ujwl\u0080f)
		{
		}

		// Token: 0x0600EBCA RID: 60362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBCA")]
		[Address(RVA = "0x13289BC", Offset = "0x13289BC", VA = "0x7BBBB289BC")]
		protected void Ek|hO{y(Player.yyEoKfi \u0082Ujwl\u0080f)
		{
		}

		// Token: 0x0600EBCB RID: 60363 RVA: 0x00042C90 File Offset: 0x00040E90
		[Token(Token = "0x600EBCB")]
		[Address(RVA = "0x13289D0", Offset = "0x13289D0", VA = "0x7BBBB289D0")]
		protected bool SOkgdyS(Player.yyEoKfi \u0082Ujwl\u0080f)
		{
			return default(bool);
		}

		// Token: 0x0600EBCC RID: 60364 RVA: 0x00042CA8 File Offset: 0x00040EA8
		[Token(Token = "0x600EBCC")]
		[Address(RVA = "0x13289E8", Offset = "0x13289E8", VA = "0x7BBBB289E8")]
		protected float ~epbIf}(Player.yyEoKfi \u0082Ujwl\u0080f)
		{
			return 0f;
		}

		// Token: 0x0600EBCD RID: 60365 RVA: 0x00042CC0 File Offset: 0x00040EC0
		[Token(Token = "0x600EBCD")]
		[Address(RVA = "0x13289FC", Offset = "0x13289FC", VA = "0x7BBBB289FC")]
		protected float FjKfq(Player.yyEoKfi \u0082Ujwl\u0080f)
		{
			return 0f;
		}

		// Token: 0x0600EBCE RID: 60366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBCE")]
		[Address(RVA = "0x12E93DC", Offset = "0x12E93DC", VA = "0x7BBBAE93DC")]
		protected void wOazrev()
		{
		}

		// Token: 0x0600EBCF RID: 60367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBCF")]
		[Address(RVA = "0x1328A14", Offset = "0x1328A14", VA = "0x7BBBB28A14")]
		protected void w()
		{
		}

		// Token: 0x0600EBD0 RID: 60368 RVA: 0x00042CD8 File Offset: 0x00040ED8
		[Token(Token = "0x600EBD0")]
		[Address(RVA = "0x1328A28", Offset = "0x1328A28", VA = "0x7BBBB28A28")]
		public bool IsInNoHeadShotState()
		{
			return default(bool);
		}

		// Token: 0x0600EBD1 RID: 60369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBD1")]
		[Address(RVA = "0x12E9490", Offset = "0x12E9490", VA = "0x7BBBAE9490")]
		private void BiEic{C()
		{
		}

		// Token: 0x0600EBD2 RID: 60370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBD2")]
		[Address(RVA = "0x1328A3C", Offset = "0x1328A3C", VA = "0x7BBBB28A3C")]
		public void RefreshCrouchScatterState()
		{
		}

		// Token: 0x0600EBD3 RID: 60371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBD3")]
		[Address(RVA = "0x1328B28", Offset = "0x1328B28", VA = "0x7BBBB28B28")]
		public void StopCrouchScatterState()
		{
		}

		// Token: 0x0600EBD4 RID: 60372 RVA: 0x00042CF0 File Offset: 0x00040EF0
		[Token(Token = "0x600EBD4")]
		[Address(RVA = "0x1309654", Offset = "0x1309654", VA = "0x7BBBB09654")]
		private bool TQihYcu()
		{
			return default(bool);
		}

		// Token: 0x0600EBD5 RID: 60373 RVA: 0x00042D08 File Offset: 0x00040F08
		[Token(Token = "0x600EBD5")]
		[Address(RVA = "0x1328B34", Offset = "0x1328B34", VA = "0x7BBBB28B34")]
		private bool Nf}a}fB()
		{
			return default(bool);
		}

		// Token: 0x0600EBD6 RID: 60374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBD6")]
		[Address(RVA = "0x1309664", Offset = "0x1309664", VA = "0x7BBBB09664")]
		private void pwlIfxB(ref Vector3 }LBVshd, float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EBD7 RID: 60375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBD7")]
		[Address(RVA = "0x1328C78", Offset = "0x1328C78", VA = "0x7BBBB28C78")]
		public void OnCronchToStandOrJump()
		{
		}

		// Token: 0x0600EBD8 RID: 60376 RVA: 0x00042D20 File Offset: 0x00040F20
		[Token(Token = "0x600EBD8")]
		[Address(RVA = "0x1328CC8", Offset = "0x1328CC8", VA = "0x7BBBB28CC8")]
		public bool GetMeshBounds(ref Bounds ~|HsACl)
		{
			return default(bool);
		}

		// Token: 0x0600EBD9 RID: 60377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBD9")]
		[Address(RVA = "0x12E954C", Offset = "0x12E954C", VA = "0x7BBBAE954C")]
		private void y]qdlRR()
		{
		}

		// Token: 0x0600EBDA RID: 60378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDA")]
		[Address(RVA = "0x12E5778", Offset = "0x12E5778", VA = "0x7BBBAE5778")]
		private void E\u0080peUwF()
		{
		}

		// Token: 0x0600EBDB RID: 60379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDB")]
		[Address(RVA = "0x13131FC", Offset = "0x13131FC", VA = "0x7BBBB131FC")]
		private void aQEQeNI()
		{
		}

		// Token: 0x0600EBDC RID: 60380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDC")]
		[Address(RVA = "0x12E547C", Offset = "0x12E547C", VA = "0x7BBBAE547C")]
		private void DuhSBlX()
		{
		}

		// Token: 0x0600EBDD RID: 60381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDD")]
		[Address(RVA = "0x1328D7C", Offset = "0x1328D7C", VA = "0x7BBBB28D7C")]
		private void GL~\u0082hWE()
		{
		}

		// Token: 0x0600EBDE RID: 60382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDE")]
		[Address(RVA = "0x1328D80", Offset = "0x1328D80", VA = "0x7BBBB28D80")]
		private void S^Ae\u0080YF()
		{
		}

		// Token: 0x0600EBDF RID: 60383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDF")]
		[Address(RVA = "0x1328D84", Offset = "0x1328D84", VA = "0x7BBBB28D84")]
		public void Set1PEffect()
		{
		}

		// Token: 0x0600EBE0 RID: 60384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE0")]
		[Address(RVA = "0x1328E28", Offset = "0x1328E28", VA = "0x7BBBB28E28")]
		public void Set3PEffect()
		{
		}

		// Token: 0x0600EBE1 RID: 60385 RVA: 0x00042D38 File Offset: 0x00040F38
		[Token(Token = "0x600EBE1")]
		[Address(RVA = "0x1328ECC", Offset = "0x1328ECC", VA = "0x7BBBB28ECC")]
		public bool HasEpicClothesActionEffect()
		{
			return default(bool);
		}

		// Token: 0x0600EBE2 RID: 60386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE2")]
		[Address(RVA = "0x1328F6C", Offset = "0x1328F6C", VA = "0x7BBBB28F6C")]
		public void RequestPlayEpicClothesActionEffect()
		{
		}

		// Token: 0x0600EBE3 RID: 60387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE3")]
		[Address(RVA = "0x1329004", Offset = "0x1329004", VA = "0x7BBBB29004")]
		public void PlayEpicClothesActionEffect(sbyte OSvO{nh = 0)
		{
		}

		// Token: 0x0600EBE4 RID: 60388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE4")]
		[Address(RVA = "0x13290BC", Offset = "0x13290BC", VA = "0x7BBBB290BC")]
		public void BombModeRemoveBomb()
		{
		}

		// Token: 0x0600EBE5 RID: 60389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE5")]
		[Address(RVA = "0x12F31F4", Offset = "0x12F31F4", VA = "0x7BBBAF31F4")]
		private void BKE}Hh\u0080(LevelEmote atO}Pkb)
		{
		}

		// Token: 0x0600EBE6 RID: 60390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE6")]
		[Address(RVA = "0x12F8588", Offset = "0x12F8588", VA = "0x7BBBAF8588")]
		private void PkAzyfj(LevelEmote atO}Pkb)
		{
		}

		// Token: 0x0600EBE7 RID: 60391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE7")]
		[Address(RVA = "0x131114C", Offset = "0x131114C", VA = "0x7BBBB1114C")]
		private void NDIo()
		{
		}

		// Token: 0x0600EBE8 RID: 60392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE8")]
		[Address(RVA = "0x12FA978", Offset = "0x12FA978", VA = "0x7BBBAFA978")]
		private void ]QZ[t}P(BaseLevelObject AhM|\u0082fg)
		{
		}

		// Token: 0x0600EBE9 RID: 60393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBE9")]
		[Address(RVA = "0x12F8BFC", Offset = "0x12F8BFC", VA = "0x7BBBAF8BFC")]
		private void rLXg\u0080\u0082^()
		{
		}

		// Token: 0x0600EBEA RID: 60394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBEA")]
		[Address(RVA = "0x1329508", Offset = "0x1329508", VA = "0x7BBBB29508", Slot = "179")]
		public virtual void ForceUpdateAnimatorUMAChangeCallBack(UMAData QmG~NaB)
		{
		}

		// Token: 0x0600EBEB RID: 60395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBEB")]
		[Address(RVA = "0x132950C", Offset = "0x132950C", VA = "0x7BBBB2950C")]
		public void ForceUpdateAnimator()
		{
		}

		// Token: 0x0600EBEC RID: 60396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBEC")]
		[Address(RVA = "0x13295A4", Offset = "0x13295A4", VA = "0x7BBBB295A4", Slot = "180")]
		public virtual void CatchAnimComponentPlayAnimID(AnimationID ^`QEUlJ)
		{
		}

		// Token: 0x0600EBED RID: 60397 RVA: 0x00042D50 File Offset: 0x00040F50
		[Token(Token = "0x600EBED")]
		[Address(RVA = "0x1329678", Offset = "0x1329678", VA = "0x7BBBB29678", Slot = "181")]
		public virtual bool IsIgonreWeaponFireControl()
		{
			return default(bool);
		}

		// Token: 0x0600EBEE RID: 60398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EBEE")]
		[Address(RVA = "0x1329680", Offset = "0x1329680", VA = "0x7BBBB29680", Slot = "182")]
		public virtual Dictionary<int, int> GetGameControlMappingToSkillIndexMap()
		{
			return null;
		}

		// Token: 0x0600EBEF RID: 60399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EBEF")]
		[Address(RVA = "0x1329688", Offset = "0x1329688", VA = "0x7BBBB29688", Slot = "183")]
		public virtual Dictionary<KeyCode, int> GetKeyCodeToSkillIndexMap()
		{
			return null;
		}

		// Token: 0x0600EBF0 RID: 60400 RVA: 0x00042D68 File Offset: 0x00040F68
		[Token(Token = "0x600EBF0")]
		[Address(RVA = "0x1329690", Offset = "0x1329690", VA = "0x7BBBB29690", Slot = "184")]
		public virtual bool IsOverrdieFastRunControl()
		{
			return default(bool);
		}

		// Token: 0x0600EBF1 RID: 60401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF1")]
		[Address(RVA = "0x1329698", Offset = "0x1329698", VA = "0x7BBBB29698")]
		public void StopUseCurInventoryOnHand()
		{
		}

		// Token: 0x0600EBF2 RID: 60402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF2")]
		[Address(RVA = "0x1311954", Offset = "0x1311954", VA = "0x7BBBB11954")]
		public void SetAllPlayerThermalView(bool wqTuwxJ)
		{
		}

		// Token: 0x0600EBF3 RID: 60403 RVA: 0x00042D80 File Offset: 0x00040F80
		[Token(Token = "0x600EBF3")]
		[Address(RVA = "0x12F8B50", Offset = "0x12F8B50", VA = "0x7BBBAF8B50")]
		public bool JudgeInAttack()
		{
			return default(bool);
		}

		// Token: 0x0600EBF4 RID: 60404 RVA: 0x00042D98 File Offset: 0x00040F98
		[Token(Token = "0x600EBF4")]
		[Address(RVA = "0x1329770", Offset = "0x1329770", VA = "0x7BBBB29770")]
		public bool JudgeInDefence()
		{
			return default(bool);
		}

		// Token: 0x0600EBF5 RID: 60405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF5")]
		[Address(RVA = "0x1329780", Offset = "0x1329780", VA = "0x7BBBB29780")]
		public void StartCrouching()
		{
		}

		// Token: 0x0600EBF6 RID: 60406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF6")]
		[Address(RVA = "0x1329BA4", Offset = "0x1329BA4", VA = "0x7BBBB29BA4")]
		public void StopCrouching()
		{
		}

		// Token: 0x0600EBF7 RID: 60407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF7")]
		[Address(RVA = "0x12ED074", Offset = "0x12ED074", VA = "0x7BBBAED074")]
		private void ~YBS\u0082gM()
		{
		}

		// Token: 0x0600EBF8 RID: 60408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF8")]
		[Address(RVA = "0x12E466C", Offset = "0x12E466C", VA = "0x7BBBAE466C")]
		public void ClearHumanTireIAmIn(bool TkVjP~D, [Optional] LevelTriggerHumanTire Oyl[MZg)
		{
		}

		// Token: 0x0600EBF9 RID: 60409 RVA: 0x00042DB0 File Offset: 0x00040FB0
		[Token(Token = "0x600EBF9")]
		[Address(RVA = "0x1329BA8", Offset = "0x1329BA8", VA = "0x7BBBB29BA8", Slot = "185")]
		public virtual bool IsIgnorePlayerAudioComponent()
		{
			return default(bool);
		}

		// Token: 0x0600EBFA RID: 60410 RVA: 0x00042DC8 File Offset: 0x00040FC8
		[Token(Token = "0x600EBFA")]
		[Address(RVA = "0x1329BB0", Offset = "0x1329BB0", VA = "0x7BBBB29BB0", Slot = "186")]
		public virtual bool IsIgnoreHighFalling()
		{
			return default(bool);
		}

		// Token: 0x0600EBFB RID: 60411 RVA: 0x00042DE0 File Offset: 0x00040FE0
		[Token(Token = "0x600EBFB")]
		[Address(RVA = "0x1329BB8", Offset = "0x1329BB8", VA = "0x7BBBB29BB8", Slot = "187")]
		public virtual bool IsNeedAimAssists()
		{
			return default(bool);
		}

		// Token: 0x0600EBFC RID: 60412 RVA: 0x00042DF8 File Offset: 0x00040FF8
		[Token(Token = "0x600EBFC")]
		[Address(RVA = "0x1329C00", Offset = "0x1329C00", VA = "0x7BBBB29C00")]
		private bool ~VMQlqL()
		{
			return default(bool);
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x0600EBFD RID: 60413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700106A")]
		public virtual BaseProfileInfo W
		{
			[Token(Token = "0x600EBFD")]
			[Address(RVA = "0x1329D0C", Offset = "0x1329D0C", VA = "0x7BBBB29D0C", Slot = "188")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EBFE RID: 60414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBFE")]
		[Address(RVA = "0x1329D14", Offset = "0x1329D14", VA = "0x7BBBB29D14")]
		public void SyncTeleportDoorUseInfo(cvTEe[K ~S`Xinb)
		{
		}

		// Token: 0x0600EBFF RID: 60415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBFF")]
		[Address(RVA = "0x1329D68", Offset = "0x1329D68", VA = "0x7BBBB29D68")]
		public void SyncDriftBottleUseState(bool oIQHUuy)
		{
		}

		// Token: 0x0600EC00 RID: 60416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC00")]
		[Address(RVA = "0x12CF7B8", Offset = "0x12CF7B8", VA = "0x7BBBACF7B8")]
		public void RecycleCurrentProp()
		{
		}

		// Token: 0x0600EC01 RID: 60417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC01")]
		[Address(RVA = "0x1329F7C", Offset = "0x1329F7C", VA = "0x7BBBB29F7C")]
		public void ResetSimulationHP()
		{
		}

		// Token: 0x0600EC02 RID: 60418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC02")]
		[Address(RVA = "0x130E200", Offset = "0x130E200", VA = "0x7BBBB0E200")]
		public ZjcDgQ\u007F GetSkillByType(string Gbf\u0082KIG)
		{
			return null;
		}

		// Token: 0x0600EC03 RID: 60419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC03")]
		[Address(RVA = "0x132A004", Offset = "0x132A004", VA = "0x7BBBB2A004")]
		public Player()
		{
		}

		// Token: 0x0600EC04 RID: 60420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC04")]
		[Address(RVA = "0x132A870", Offset = "0x132A870", VA = "0x7BBBB2A870")]
		public void SyncVehicleHornAccordingToDistance(bool pJ`}xMy, Transform evHPhvv, Transform oFGCe\u0082~, ref GameObject mcHP[TF, ResourceID ^UyMODM)
		{
		}

		// Token: 0x0600EC05 RID: 60421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC05")]
		[Address(RVA = "0x132AE38", Offset = "0x132AE38", VA = "0x7BBBB2AE38", Slot = "189")]
		public virtual void ChangeFog(bool IyxY|Aa)
		{
		}

		// Token: 0x0600EC06 RID: 60422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC06")]
		[Address(RVA = "0x132AE3C", Offset = "0x132AE3C", VA = "0x7BBBB2AE3C")]
		public void CheckAndTryGetoffAirTransporter()
		{
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600EC07 RID: 60423 RVA: 0x00042E10 File Offset: 0x00041010
		// (set) Token: 0x0600EC08 RID: 60424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700106B")]
		public bool vIJwqwF
		{
			[Token(Token = "0x600EC07")]
			[Address(RVA = "0x130865C", Offset = "0x130865C", VA = "0x7BBBB0865C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A70C", Offset = "0x114A70C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EC08")]
			[Address(RVA = "0x132AEEC", Offset = "0x132AEEC", VA = "0x7BBBB2AEEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A71C", Offset = "0x114A71C")]
			set
			{
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600EC09 RID: 60425 RVA: 0x00042E28 File Offset: 0x00041028
		// (set) Token: 0x0600EC0A RID: 60426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700106C")]
		public bool xnXO{Mw
		{
			[Token(Token = "0x600EC09")]
			[Address(RVA = "0x130972C", Offset = "0x130972C", VA = "0x7BBBB0972C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A72C", Offset = "0x114A72C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EC0A")]
			[Address(RVA = "0x132AEF8", Offset = "0x132AEF8", VA = "0x7BBBB2AEF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A73C", Offset = "0x114A73C")]
			set
			{
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600EC0B RID: 60427 RVA: 0x00042E40 File Offset: 0x00041040
		// (set) Token: 0x0600EC0C RID: 60428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700106D")]
		public bool GeiKqfL
		{
			[Token(Token = "0x600EC0B")]
			[Address(RVA = "0x132AF04", Offset = "0x132AF04", VA = "0x7BBBB2AF04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A74C", Offset = "0x114A74C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EC0C")]
			[Address(RVA = "0x132AF0C", Offset = "0x132AF0C", VA = "0x7BBBB2AF0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A75C", Offset = "0x114A75C")]
			set
			{
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x0600EC0D RID: 60429 RVA: 0x00042E58 File Offset: 0x00041058
		// (set) Token: 0x0600EC0E RID: 60430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700106E")]
		public bool ^ENc[d{
		{
			[Token(Token = "0x600EC0D")]
			[Address(RVA = "0x12D5CE4", Offset = "0x12D5CE4", VA = "0x7BBBAD5CE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A76C", Offset = "0x114A76C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EC0E")]
			[Address(RVA = "0x132AF18", Offset = "0x132AF18", VA = "0x7BBBB2AF18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A77C", Offset = "0x114A77C")]
			set
			{
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x0600EC0F RID: 60431 RVA: 0x00042E70 File Offset: 0x00041070
		// (set) Token: 0x0600EC10 RID: 60432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700106F")]
		public bool [\u0082Cs\u0081d{
		{
			[Token(Token = "0x600EC0F")]
			[Address(RVA = "0x132AF24", Offset = "0x132AF24", VA = "0x7BBBB2AF24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A78C", Offset = "0x114A78C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EC10")]
			[Address(RVA = "0x132AF2C", Offset = "0x132AF2C", VA = "0x7BBBB2AF2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A79C", Offset = "0x114A79C")]
			set
			{
			}
		}

		// Token: 0x0600EC11 RID: 60433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC11")]
		[Address(RVA = "0x132AF38", Offset = "0x132AF38", VA = "0x7BBBB2AF38")]
		protected xM\u0080cEzB q]gEjKk(xM\u0080cEzB sHhISXk, [Optional] GameObject s\u0081cMn\u0081D)
		{
			return null;
		}

		// Token: 0x0600EC12 RID: 60434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC12")]
		[Address(RVA = "0x132B010", Offset = "0x132B010", VA = "0x7BBBB2B010")]
		protected void \u007Fk|}vyq()
		{
		}

		// Token: 0x0600EC13 RID: 60435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC13")]
		[Address(RVA = "0x132B0E4", Offset = "0x132B0E4", VA = "0x7BBBB2B0E4", Slot = "190")]
		public virtual void OnActSkillFinished([JfMv\u0082} Gbf\u0082KIG)
		{
		}

		// Token: 0x0600EC14 RID: 60436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC14")]
		[Address(RVA = "0x12FCF38", Offset = "0x12FCF38", VA = "0x7BBBAFCF38")]
		protected void <<EMPTY_NAME>>(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC15 RID: 60437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC15")]
		[Address(RVA = "0x132B0E8", Offset = "0x132B0E8", VA = "0x7BBBB2B0E8", Slot = "191")]
		public virtual void CastSkillByIndex(int z]|XnJH, bool IyAJv\u0082J = false)
		{
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x0600EC16 RID: 60438 RVA: 0x00042E88 File Offset: 0x00041088
		[Token(Token = "0x17001070")]
		public bool if|{E
		{
			[Token(Token = "0x600EC16")]
			[Address(RVA = "0x132B1E4", Offset = "0x132B1E4", VA = "0x7BBBB2B1E4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EC17 RID: 60439 RVA: 0x00042EA0 File Offset: 0x000410A0
		[Token(Token = "0x600EC17")]
		[Address(RVA = "0x132B2A4", Offset = "0x132B2A4", VA = "0x7BBBB2B2A4")]
		public bool CheckActSkillCanCast(int z]|XnJH)
		{
			return default(bool);
		}

		// Token: 0x0600EC18 RID: 60440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC18")]
		[Address(RVA = "0x132B0D8", Offset = "0x132B0D8", VA = "0x7BBBB2B0D8")]
		public void ResetActSkillPlayerLockState()
		{
		}

		// Token: 0x0600EC19 RID: 60441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC19")]
		[Address(RVA = "0x132B378", Offset = "0x132B378", VA = "0x7BBBB2B378")]
		public void ShowSkillVfxEffect(Player.psnG DU[lxOk)
		{
		}

		// Token: 0x0600EC1A RID: 60442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC1A")]
		[Address(RVA = "0x132B734", Offset = "0x132B734", VA = "0x7BBBB2B734")]
		public void ClearSkillVfxEffect(Player.psnG DU[lxOk)
		{
		}

		// Token: 0x0600EC1B RID: 60443 RVA: 0x00042EB8 File Offset: 0x000410B8
		[Token(Token = "0x600EC1B")]
		[Address(RVA = "0x132B9D8", Offset = "0x132B9D8", VA = "0x7BBBB2B9D8")]
		public bool GetIsDampingNoiseBySkill(int uAmVYpE, int uLsuekJ)
		{
			return default(bool);
		}

		// Token: 0x0600EC1C RID: 60444 RVA: 0x00042ED0 File Offset: 0x000410D0
		[Token(Token = "0x600EC1C")]
		[Address(RVA = "0x132BAA4", Offset = "0x132BAA4", VA = "0x7BBBB2BAA4")]
		public bool IsTransformSkillTakingEffect()
		{
			return default(bool);
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x0600EC1D RID: 60445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001071")]
		public b]LTXBp OaVcMcc
		{
			[Token(Token = "0x600EC1D")]
			[Address(RVA = "0x12E3E1C", Offset = "0x12E3E1C", VA = "0x7BBBAE3E1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x0600EC1E RID: 60446 RVA: 0x00042EE8 File Offset: 0x000410E8
		[Token(Token = "0x17001072")]
		public bool Ydh[DsE
		{
			[Token(Token = "0x600EC1E")]
			[Address(RVA = "0x132BA9C", Offset = "0x132BA9C", VA = "0x7BBBB2BA9C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EC1F RID: 60447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC1F")]
		[Address(RVA = "0x132BB5C", Offset = "0x132BB5C", VA = "0x7BBBB2BB5C")]
		public void SyncActiveSkillStatus(uint EnvUZ]v, IJ\u007FUf\u0082c spZmonZ, float }tdI\u0080y\u0082, float }sg`pQW, uint [HiTfmQ, bool iyg{XkK)
		{
		}

		// Token: 0x0600EC20 RID: 60448 RVA: 0x00042F00 File Offset: 0x00041100
		[Token(Token = "0x600EC20")]
		[Address(RVA = "0x132BD40", Offset = "0x132BD40", VA = "0x7BBBB2BD40")]
		private ResourceID JEzhGTc()
		{
			return default(ResourceID);
		}

		// Token: 0x0600EC21 RID: 60449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC21")]
		[Address(RVA = "0x132BE08", Offset = "0x132BE08", VA = "0x7BBBB2BE08")]
		public void PutOnTransformer()
		{
		}

		// Token: 0x0600EC22 RID: 60450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC22")]
		[Address(RVA = "0x132C288", Offset = "0x132C288", VA = "0x7BBBB2C288")]
		public void TakeOffTransformer()
		{
		}

		// Token: 0x0600EC23 RID: 60451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC23")]
		[Address(RVA = "0x132C0BC", Offset = "0x132C0BC", VA = "0x7BBBB2C0BC")]
		public void SetVisibiliyByTransformer(bool `esF^\u0082h)
		{
		}

		// Token: 0x0600EC24 RID: 60452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC24")]
		[Address(RVA = "0x132C334", Offset = "0x132C334", VA = "0x7BBBB2C334")]
		public void UpdateSkillHideInMap(bool F~AR^nk)
		{
		}

		// Token: 0x0600EC25 RID: 60453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC25")]
		[Address(RVA = "0x132C390", Offset = "0x132C390", VA = "0x7BBBB2C390")]
		public void UpdateDetectiveSkillEffect(bool \u0081OTRX|})
		{
		}

		// Token: 0x0600EC26 RID: 60454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC26")]
		[Address(RVA = "0x132C624", Offset = "0x132C624", VA = "0x7BBBB2C624")]
		public void OnSyncPetSkillMarkCuringEnemy(uint ajPVAwa, uint ^k]bGLZ, List<uint> \u0081jq\u0082~el)
		{
		}

		// Token: 0x0600EC27 RID: 60455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC27")]
		[Address(RVA = "0x1308438", Offset = "0x1308438", VA = "0x7BBBB08438")]
		public void UpdatePetSkillMarkCuringEnemy(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC28 RID: 60456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC28")]
		[Address(RVA = "0x12E92E0", Offset = "0x12E92E0", VA = "0x7BBBAE92E0")]
		private void DjkKso~()
		{
		}

		// Token: 0x0600EC29 RID: 60457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC29")]
		[Address(RVA = "0x130D638", Offset = "0x130D638", VA = "0x7BBBB0D638")]
		public void PlayAssistantShot(JjGdwja BY|m\u0081Jy)
		{
		}

		// Token: 0x0600EC2A RID: 60458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC2A")]
		[Address(RVA = "0x130D64C", Offset = "0x130D64C", VA = "0x7BBBB0D64C")]
		public void ShowEventTriggerMark(zv^\u0082S^X ^\u0082E}Zzs)
		{
		}

		// Token: 0x0600EC2B RID: 60459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC2B")]
		[Address(RVA = "0x132CD4C", Offset = "0x132CD4C", VA = "0x7BBBB2CD4C")]
		public void ClearEventTriggerMark(zv^\u0082S^X ^\u0082E}Zzs)
		{
		}

		// Token: 0x0600EC2C RID: 60460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC2C")]
		[Address(RVA = "0x132CD60", Offset = "0x132CD60", VA = "0x7BBBB2CD60")]
		public void ShowEventTriggerMark(zv^\u0082S^X ^\u0082E}Zzs, Vector3 \u007FefF\u0081U^)
		{
		}

		// Token: 0x0600EC2D RID: 60461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC2D")]
		[Address(RVA = "0x132CD74", Offset = "0x132CD74", VA = "0x7BBBB2CD74")]
		public void ShowAssistantMarkItem(uint beCqzR], uint JKbhxLn, Vector3 \u007FefF\u0081U^)
		{
		}

		// Token: 0x0600EC2E RID: 60462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC2E")]
		[Address(RVA = "0x132CD88", Offset = "0x132CD88", VA = "0x7BBBB2CD88")]
		public void RequestMarkEntity(uint SfusqvD, uint JKbhxLn, Vector3 \u007FefF\u0081U^, bool EI~[IIt)
		{
		}

		// Token: 0x0600EC2F RID: 60463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC2F")]
		[Address(RVA = "0x132CDA0", Offset = "0x132CDA0", VA = "0x7BBBB2CDA0")]
		public void TryRemoveAssistantMark(uint SfusqvD, uint JKbhxLn)
		{
		}

		// Token: 0x0600EC30 RID: 60464 RVA: 0x00042F18 File Offset: 0x00041118
		[Token(Token = "0x600EC30")]
		[Address(RVA = "0x132CEF4", Offset = "0x132CEF4", VA = "0x7BBBB2CEF4")]
		public bool CheckMarkItemInfo(uint SfusqvD, uint JKbhxLn)
		{
			return default(bool);
		}

		// Token: 0x0600EC31 RID: 60465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC31")]
		[Address(RVA = "0x132CF08", Offset = "0x132CF08", VA = "0x7BBBB2CF08")]
		public void ClearMarkItemCacheInfo()
		{
		}

		// Token: 0x0600EC32 RID: 60466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC32")]
		[Address(RVA = "0x132CF1C", Offset = "0x132CF1C", VA = "0x7BBBB2CF1C")]
		public void RemoveAssistantMark({QAb\u0082~u {NRR\u0081yd, uint SfusqvD, uint JKbhxLn)
		{
		}

		// Token: 0x0600EC33 RID: 60467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC33")]
		[Address(RVA = "0x132CF58", Offset = "0x132CF58", VA = "0x7BBBB2CF58")]
		public void RequestAssistantShot(JjGdwja Dr~VNBn)
		{
		}

		// Token: 0x0600EC34 RID: 60468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC34")]
		[Address(RVA = "0x132CF6C", Offset = "0x132CF6C", VA = "0x7BBBB2CF6C")]
		public void RequestAssistantShot(JjGdwja Dr~VNBn, zv^\u0082S^X `OMeC[p)
		{
		}

		// Token: 0x0600EC35 RID: 60469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC35")]
		[Address(RVA = "0x132CF80", Offset = "0x132CF80", VA = "0x7BBBB2CF80")]
		public void RequestAssistantShot(JjGdwja Dr~VNBn, zv^\u0082S^X `OMeC[p, Vector3 CWMm{IV)
		{
		}

		// Token: 0x0600EC36 RID: 60470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC36")]
		[Address(RVA = "0x132CF94", Offset = "0x132CF94", VA = "0x7BBBB2CF94")]
		public LevelContainerBase GetAssistantCurrentHintContainer()
		{
			return null;
		}

		// Token: 0x0600EC37 RID: 60471 RVA: 0x00042F30 File Offset: 0x00041130
		[Token(Token = "0x600EC37")]
		[Address(RVA = "0x132D3C8", Offset = "0x132D3C8", VA = "0x7BBBB2D3C8")]
		public bool CheckContainerSame(uint JKbhxLn)
		{
			return default(bool);
		}

		// Token: 0x0600EC38 RID: 60472 RVA: 0x00042F48 File Offset: 0x00041148
		[Token(Token = "0x600EC38")]
		[Address(RVA = "0x132D3DC", Offset = "0x132D3DC", VA = "0x7BBBB2D3DC")]
		public float GetMarkItemLastUseTime()
		{
			return 0f;
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600EC39 RID: 60473 RVA: 0x00042F60 File Offset: 0x00041160
		[Token(Token = "0x17001073")]
		public bool humaVH\u0082
		{
			[Token(Token = "0x600EC39")]
			[Address(RVA = "0x12DFC7C", Offset = "0x12DFC7C", VA = "0x7BBBADFC7C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600EC3A RID: 60474 RVA: 0x00042F78 File Offset: 0x00041178
		[Token(Token = "0x17001074")]
		public bool {Du\u0082\u0081[\u0080
		{
			[Token(Token = "0x600EC3A")]
			[Address(RVA = "0x12FBC68", Offset = "0x12FBC68", VA = "0x7BBBAFBC68")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x0600EC3B RID: 60475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001075")]
		public ClimbingTrigger pvr[GYF
		{
			[Token(Token = "0x600EC3B")]
			[Address(RVA = "0x132D3F4", Offset = "0x132D3F4", VA = "0x7BBBB2D3F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EC3C RID: 60476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC3C")]
		[Address(RVA = "0x12E007C", Offset = "0x12E007C", VA = "0x7BBBAE007C")]
		public void RequestStartClimb()
		{
		}

		// Token: 0x0600EC3D RID: 60477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC3D")]
		[Address(RVA = "0x1308664", Offset = "0x1308664", VA = "0x7BBBB08664")]
		public void UpdateClimbCamera(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC3E RID: 60478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC3E")]
		[Address(RVA = "0x132D508", Offset = "0x132D508", VA = "0x7BBBB2D508")]
		public void UpdateCrossOverJumpTimeAndFallTime(float xXwOTDy, float J\u0081hTaPz)
		{
		}

		// Token: 0x0600EC3F RID: 60479 RVA: 0x00042F90 File Offset: 0x00041190
		[Token(Token = "0x600EC3F")]
		[Address(RVA = "0x12FBB1C", Offset = "0x12FBB1C", VA = "0x7BBBAFBB1C")]
		public bool CheckPhysPose_Climb()
		{
			return default(bool);
		}

		// Token: 0x0600EC40 RID: 60480 RVA: 0x00042FA8 File Offset: 0x000411A8
		[Token(Token = "0x600EC40")]
		[Address(RVA = "0x12FBBFC", Offset = "0x12FBBFC", VA = "0x7BBBAFBBFC")]
		public bool CheckIceWallBlock()
		{
			return default(bool);
		}

		// Token: 0x0600EC41 RID: 60481 RVA: 0x00042FC0 File Offset: 0x000411C0
		[Token(Token = "0x600EC41")]
		[Address(RVA = "0x132D5A4", Offset = "0x132D5A4", VA = "0x7BBBB2D5A4")]
		public Vector2 GetCrossOverSpeed(float \u0081}x[tOF)
		{
			return default(Vector2);
		}

		// Token: 0x0600EC42 RID: 60482 RVA: 0x00042FD8 File Offset: 0x000411D8
		[Token(Token = "0x600EC42")]
		[Address(RVA = "0x132D7E8", Offset = "0x132D7E8", VA = "0x7BBBB2D7E8")]
		private bool jw]Uwu}(float \u0081}x[tOF)
		{
			return default(bool);
		}

		// Token: 0x0600EC43 RID: 60483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC43")]
		[Address(RVA = "0x12CCC98", Offset = "0x12CCC98", VA = "0x7BBBACCC98")]
		public void RequestEndClimb()
		{
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x0600EC44 RID: 60484 RVA: 0x00042FF0 File Offset: 0x000411F0
		[Token(Token = "0x17001076")]
		public bool qGVWm\u0082H
		{
			[Token(Token = "0x600EC44")]
			[Address(RVA = "0x12C9394", Offset = "0x12C9394", VA = "0x7BBBAC9394")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x0600EC45 RID: 60485 RVA: 0x00043008 File Offset: 0x00041208
		[Token(Token = "0x17001077")]
		public bool }}^o^Ul
		{
			[Token(Token = "0x600EC45")]
			[Address(RVA = "0x12D1BC0", Offset = "0x12D1BC0", VA = "0x7BBBAD1BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EC46 RID: 60486 RVA: 0x00043020 File Offset: 0x00041220
		[Token(Token = "0x600EC46")]
		[Address(RVA = "0x132D87C", Offset = "0x132D87C", VA = "0x7BBBB2D87C", Slot = "192")]
		public virtual bool RequestCreep()
		{
			return default(bool);
		}

		// Token: 0x0600EC47 RID: 60487 RVA: 0x00043038 File Offset: 0x00041238
		[Token(Token = "0x600EC47")]
		[Address(RVA = "0x132DBD8", Offset = "0x132DBD8", VA = "0x7BBBB2DBD8", Slot = "193")]
		public virtual bool RequestUnCreep(VCDxuoO wlEMBeh)
		{
			return default(bool);
		}

		// Token: 0x0600EC48 RID: 60488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC48")]
		[Address(RVA = "0x130485C", Offset = "0x130485C", VA = "0x7BBBB0485C")]
		protected void \u007FiU[lpZ()
		{
		}

		// Token: 0x0600EC49 RID: 60489 RVA: 0x00043050 File Offset: 0x00041250
		[Token(Token = "0x600EC49")]
		[Address(RVA = "0x1309138", Offset = "0x1309138", VA = "0x7BBBB09138")]
		protected float CxuVZ|D()
		{
			return 0f;
		}

		// Token: 0x0600EC4A RID: 60490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC4A")]
		[Address(RVA = "0x132D3FC", Offset = "0x132D3FC", VA = "0x7BBBB2D3FC")]
		public void RequestUnSightIfNeed()
		{
		}

		// Token: 0x0600EC4B RID: 60491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC4B")]
		[Address(RVA = "0x132DEA4", Offset = "0x132DEA4", VA = "0x7BBBB2DEA4")]
		public void RequestBackToSightingIfNeed()
		{
		}

		// Token: 0x0600EC4C RID: 60492 RVA: 0x00043068 File Offset: 0x00041268
		[Token(Token = "0x600EC4C")]
		[Address(RVA = "0x132DE9C", Offset = "0x132DE9C", VA = "0x7BBBB2DE9C")]
		private bool FBBfB~Y()
		{
			return default(bool);
		}

		// Token: 0x0600EC4D RID: 60493 RVA: 0x00043080 File Offset: 0x00041280
		[Token(Token = "0x600EC4D")]
		[Address(RVA = "0x12D6578", Offset = "0x12D6578", VA = "0x7BBBAD6578")]
		public bool CheckCeiling(float \u0081aG~GsH = 1000f)
		{
			return default(bool);
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x0600EC4E RID: 60494 RVA: 0x00043098 File Offset: 0x00041298
		[Token(Token = "0x17001078")]
		public bool ZaahCNv
		{
			[Token(Token = "0x600EC4E")]
			[Address(RVA = "0x132DF90", Offset = "0x132DF90", VA = "0x7BBBB2DF90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x0600EC4F RID: 60495 RVA: 0x000430B0 File Offset: 0x000412B0
		[Token(Token = "0x17001079")]
		public bool JpdWauJ
		{
			[Token(Token = "0x600EC4F")]
			[Address(RVA = "0x132DFA4", Offset = "0x132DFA4", VA = "0x7BBBB2DFA4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EC50 RID: 60496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC50")]
		[Address(RVA = "0x132E070", Offset = "0x132E070", VA = "0x7BBBB2E070")]
		public void ShowDoubleJumpEffect()
		{
		}

		// Token: 0x0600EC51 RID: 60497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC51")]
		[Address(RVA = "0x132E15C", Offset = "0x132E15C", VA = "0x7BBBB2E15C")]
		public void EndDoubleJumpEffect()
		{
		}

		// Token: 0x0600EC52 RID: 60498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC52")]
		[Address(RVA = "0x132E218", Offset = "0x132E218", VA = "0x7BBBB2E218")]
		public A\u0082[c^\u007FE GetDoubleJumpData()
		{
			return null;
		}

		// Token: 0x0600EC53 RID: 60499 RVA: 0x000430C8 File Offset: 0x000412C8
		[Token(Token = "0x600EC53")]
		[Address(RVA = "0x132E2D8", Offset = "0x132E2D8", VA = "0x7BBBB2E2D8", Slot = "194")]
		public virtual bool RequestStopDoubleJump()
		{
			return default(bool);
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x0600EC54 RID: 60500 RVA: 0x000430E0 File Offset: 0x000412E0
		[Token(Token = "0x1700107A")]
		public bool Fwz]fSv
		{
			[Token(Token = "0x600EC54")]
			[Address(RVA = "0x12CC634", Offset = "0x12CC634", VA = "0x7BBBACC634")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x0600EC55 RID: 60501 RVA: 0x000430F8 File Offset: 0x000412F8
		[Token(Token = "0x1700107B")]
		public bool CcmaSWW
		{
			[Token(Token = "0x600EC55")]
			[Address(RVA = "0x132E2E0", Offset = "0x132E2E0", VA = "0x7BBBB2E2E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EC56 RID: 60502 RVA: 0x00043110 File Offset: 0x00041310
		[Token(Token = "0x600EC56")]
		[Address(RVA = "0x132E31C", Offset = "0x132E31C", VA = "0x7BBBB2E31C", Slot = "195")]
		public virtual bool RequestFastRun()
		{
			return default(bool);
		}

		// Token: 0x0600EC57 RID: 60503 RVA: 0x00043128 File Offset: 0x00041328
		[Token(Token = "0x600EC57")]
		[Address(RVA = "0x132E5D8", Offset = "0x132E5D8", VA = "0x7BBBB2E5D8", Slot = "196")]
		public virtual bool RequestStopFastRun()
		{
			return default(bool);
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x0600EC58 RID: 60504 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EC59 RID: 60505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700107C")]
		public eGHwBLs Ydxzspe
		{
			[Token(Token = "0x600EC58")]
			[Address(RVA = "0x132E6A0", Offset = "0x132E6A0", VA = "0x7BBBB2E6A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EC59")]
			[Address(RVA = "0x132E6A8", Offset = "0x132E6A8", VA = "0x7BBBB2E6A8")]
			set
			{
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x0600EC5A RID: 60506 RVA: 0x00043140 File Offset: 0x00041340
		[Token(Token = "0x1700107D")]
		public bool b
		{
			[Token(Token = "0x600EC5A")]
			[Address(RVA = "0x132E778", Offset = "0x132E778", VA = "0x7BBBB2E778")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600EC5B RID: 60507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107E")]
		public FoldWingConfigData |OMnw\u0082y
		{
			[Token(Token = "0x600EC5B")]
			[Address(RVA = "0x12D1BB8", Offset = "0x12D1BB8", VA = "0x7BBBAD1BB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EC5C RID: 60508 RVA: 0x00043158 File Offset: 0x00041358
		[Token(Token = "0x600EC5C")]
		[Address(RVA = "0x132E788", Offset = "0x132E788", VA = "0x7BBBB2E788")]
		public bool IsShowingFoldWingModel()
		{
			return default(bool);
		}

		// Token: 0x0600EC5D RID: 60509 RVA: 0x00043170 File Offset: 0x00041370
		[Token(Token = "0x600EC5D")]
		[Address(RVA = "0x12D1AE0", Offset = "0x12D1AE0", VA = "0x7BBBAD1AE0")]
		public bool IsFoldWingGliding()
		{
			return default(bool);
		}

		// Token: 0x0600EC5E RID: 60510 RVA: 0x00043188 File Offset: 0x00041388
		[Token(Token = "0x600EC5E")]
		[Address(RVA = "0x12D1B4C", Offset = "0x12D1B4C", VA = "0x7BBBAD1B4C")]
		public bool IsFoldWingGlideFalling()
		{
			return default(bool);
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600EC5F RID: 60511 RVA: 0x000431A0 File Offset: 0x000413A0
		// (set) Token: 0x0600EC60 RID: 60512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700107F")]
		public bool biERfR|
		{
			[Token(Token = "0x600EC5F")]
			[Address(RVA = "0x132E7F8", Offset = "0x132E7F8", VA = "0x7BBBB2E7F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EC60")]
			[Address(RVA = "0x132E800", Offset = "0x132E800", VA = "0x7BBBB2E800")]
			set
			{
			}
		}

		// Token: 0x0600EC61 RID: 60513 RVA: 0x000431B8 File Offset: 0x000413B8
		[Token(Token = "0x600EC61")]
		[Address(RVA = "0x132E998", Offset = "0x132E998", VA = "0x7BBBB2E998", Slot = "197")]
		public virtual bool RequestStopFoldWing()
		{
			return default(bool);
		}

		// Token: 0x0600EC62 RID: 60514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC62")]
		[Address(RVA = "0x132E9C4", Offset = "0x132E9C4", VA = "0x7BBBB2E9C4")]
		public void ShowFoldWingModel()
		{
		}

		// Token: 0x0600EC63 RID: 60515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC63")]
		[Address(RVA = "0x132EACC", Offset = "0x132EACC", VA = "0x7BBBB2EACC")]
		public void ShowFoldWingModel(eGHwBLs C\u0080pDRv{)
		{
		}

		// Token: 0x0600EC64 RID: 60516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC64")]
		[Address(RVA = "0x132EB60", Offset = "0x132EB60", VA = "0x7BBBB2EB60")]
		public void HideFoldWingModel()
		{
		}

		// Token: 0x0600EC65 RID: 60517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC65")]
		[Address(RVA = "0x132EC1C", Offset = "0x132EC1C", VA = "0x7BBBB2EC1C")]
		public void OnStopGliding()
		{
		}

		// Token: 0x0600EC66 RID: 60518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC66")]
		[Address(RVA = "0x132EE5C", Offset = "0x132EE5C", VA = "0x7BBBB2EE5C")]
		public void OnStartGliding()
		{
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600EC67 RID: 60519 RVA: 0x000431D0 File Offset: 0x000413D0
		[Token(Token = "0x17001080")]
		public float egk\u007F\u0081fA
		{
			[Token(Token = "0x600EC67")]
			[Address(RVA = "0x132F270", Offset = "0x132F270", VA = "0x7BBBB2F270")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x0600EC68 RID: 60520 RVA: 0x000431E8 File Offset: 0x000413E8
		[Token(Token = "0x17001081")]
		public bool Bng\u0081OnP
		{
			[Token(Token = "0x600EC68")]
			[Address(RVA = "0x12D6374", Offset = "0x12D6374", VA = "0x7BBBAD6374")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EC69 RID: 60521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC69")]
		[Address(RVA = "0x12D654C", Offset = "0x12D654C", VA = "0x7BBBAD654C")]
		public void ChangeFootballVerticalSpeed(float ]M[tdcT)
		{
		}

		// Token: 0x0600EC6A RID: 60522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC6A")]
		[Address(RVA = "0x1301FCC", Offset = "0x1301FCC", VA = "0x7BBBB01FCC")]
		private void \u007FmQVAve(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC6B RID: 60523 RVA: 0x00043200 File Offset: 0x00041400
		[Token(Token = "0x600EC6B")]
		[Address(RVA = "0x12D63B0", Offset = "0x12D63B0", VA = "0x7BBBAD63B0")]
		public bool IsFootballGrounded()
		{
			return default(bool);
		}

		// Token: 0x0600EC6C RID: 60524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC6C")]
		[Address(RVA = "0x132FA18", Offset = "0x132FA18", VA = "0x7BBBB2FA18")]
		protected void JQALiSo(Vector3 }TN^\u0082ln)
		{
		}

		// Token: 0x0600EC6D RID: 60525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC6D")]
		[Address(RVA = "0x132FCB8", Offset = "0x132FCB8", VA = "0x7BBBB2FCB8")]
		protected void MWPR|aY(Vector3 }TN^\u0082ln)
		{
		}

		// Token: 0x0600EC6E RID: 60526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC6E")]
		[Address(RVA = "0x132FBBC", Offset = "0x132FBBC", VA = "0x7BBBB2FBBC")]
		protected void y{qMHV{()
		{
		}

		// Token: 0x0600EC6F RID: 60527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC6F")]
		[Address(RVA = "0x132FE5C", Offset = "0x132FE5C", VA = "0x7BBBB2FE5C")]
		private void uT{mIly(float zcNRK]k)
		{
		}

		// Token: 0x0600EC70 RID: 60528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC70")]
		[Address(RVA = "0x12EB424", Offset = "0x12EB424", VA = "0x7BBBAEB424")]
		private void eOwZLSn()
		{
		}

		// Token: 0x0600EC71 RID: 60529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC71")]
		[Address(RVA = "0x12F1A30", Offset = "0x12F1A30", VA = "0x7BBBAF1A30")]
		protected void fbVdGid(LevelTriggerFootball IVAea\u0080W, bool onlUH\u0080H = false)
		{
		}

		// Token: 0x0600EC72 RID: 60530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC72")]
		[Address(RVA = "0x132F278", Offset = "0x132F278", VA = "0x7BBBB2F278")]
		private void [waM{Ke()
		{
		}

		// Token: 0x0600EC73 RID: 60531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC73")]
		[Address(RVA = "0x133024C", Offset = "0x133024C", VA = "0x7BBBB3024C")]
		protected void z()
		{
		}

		// Token: 0x0600EC74 RID: 60532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC74")]
		[Address(RVA = "0x1330258", Offset = "0x1330258", VA = "0x7BBBB30258")]
		public void StopFootball()
		{
		}

		// Token: 0x0600EC75 RID: 60533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC75")]
		[Address(RVA = "0x12E6CA0", Offset = "0x12E6CA0", VA = "0x7BBBAE6CA0")]
		public void SetVisibleForFootball(bool wLdlWCv)
		{
		}

		// Token: 0x0600EC76 RID: 60534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC76")]
		[Address(RVA = "0x1330248", Offset = "0x1330248", VA = "0x7BBBB30248")]
		private void HNNClCp(Vector3 cC|iom\u007F)
		{
		}

		// Token: 0x0600EC77 RID: 60535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC77")]
		[Address(RVA = "0x133025C", Offset = "0x133025C", VA = "0x7BBBB3025C")]
		public void OnFootballGoals()
		{
		}

		// Token: 0x0600EC78 RID: 60536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC78")]
		[Address(RVA = "0x1330314", Offset = "0x1330314", VA = "0x7BBBB30314")]
		public void ResetPlayerWardrobeForFootball()
		{
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC79")]
		[Address(RVA = "0x13303D8", Offset = "0x13303D8", VA = "0x7BBBB303D8")]
		public void UpdatePlayerWardrobe(uint EmJdfCs)
		{
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600EC7A RID: 60538 RVA: 0x00043218 File Offset: 0x00041418
		[Token(Token = "0x17001082")]
		public bool s~mbC]G
		{
			[Token(Token = "0x600EC7A")]
			[Address(RVA = "0x1308308", Offset = "0x1308308", VA = "0x7BBBB08308")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x0600EC7B RID: 60539 RVA: 0x00043230 File Offset: 0x00041430
		[Token(Token = "0x17001083")]
		public bool GrirQSx
		{
			[Token(Token = "0x600EC7B")]
			[Address(RVA = "0x12CEB24", Offset = "0x12CEB24", VA = "0x7BBBACEB24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x0600EC7C RID: 60540 RVA: 0x00043248 File Offset: 0x00041448
		[Token(Token = "0x17001084")]
		public bool J{gFJ~a
		{
			[Token(Token = "0x600EC7C")]
			[Address(RVA = "0x12D1A6C", Offset = "0x12D1A6C", VA = "0x7BBBAD1A6C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600EC7D RID: 60541 RVA: 0x00043260 File Offset: 0x00041460
		[Token(Token = "0x17001085")]
		public bool \u007FCg}bhj
		{
			[Token(Token = "0x600EC7D")]
			[Address(RVA = "0x132E56C", Offset = "0x132E56C", VA = "0x7BBBB2E56C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x0600EC7E RID: 60542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001086")]
		public eoFJwfC UO\u0081x\u0082d{
		{
			[Token(Token = "0x600EC7E")]
			[Address(RVA = "0x13305C4", Offset = "0x13305C4", VA = "0x7BBBB305C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EC7F RID: 60543 RVA: 0x00043278 File Offset: 0x00041478
		[Token(Token = "0x600EC7F")]
		[Address(RVA = "0x13305CC", Offset = "0x13305CC", VA = "0x7BBBB305CC", Slot = "198")]
		public virtual bool RequestStartJetFly()
		{
			return default(bool);
		}

		// Token: 0x0600EC80 RID: 60544 RVA: 0x00043290 File Offset: 0x00041490
		[Token(Token = "0x600EC80")]
		[Address(RVA = "0x1330728", Offset = "0x1330728", VA = "0x7BBBB30728", Slot = "199")]
		public virtual bool RequestStopJetFly()
		{
			return default(bool);
		}

		// Token: 0x0600EC81 RID: 60545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC81")]
		[Address(RVA = "0x1330758", Offset = "0x1330758", VA = "0x7BBBB30758")]
		public void ShowJetFlyEffect()
		{
		}

		// Token: 0x0600EC82 RID: 60546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC82")]
		[Address(RVA = "0x1330814", Offset = "0x1330814", VA = "0x7BBBB30814")]
		public void EndJetFlyEffect()
		{
		}

		// Token: 0x0600EC83 RID: 60547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC83")]
		[Address(RVA = "0x13308D0", Offset = "0x13308D0", VA = "0x7BBBB308D0")]
		public void PlayJetFlyFlyingSound(ResourceID sVShSIa)
		{
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x0600EC84 RID: 60548 RVA: 0x000432A8 File Offset: 0x000414A8
		[Token(Token = "0x17001087")]
		public bool jUw[wNe
		{
			[Token(Token = "0x600EC84")]
			[Address(RVA = "0x1330AA4", Offset = "0x1330AA4", VA = "0x7BBBB30AA4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x0600EC85 RID: 60549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001088")]
		public MDsfkBx [cPIQ\u0082h
		{
			[Token(Token = "0x600EC85")]
			[Address(RVA = "0x1330B70", Offset = "0x1330B70", VA = "0x7BBBB30B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EC86 RID: 60550 RVA: 0x000432C0 File Offset: 0x000414C0
		[Token(Token = "0x600EC86")]
		[Address(RVA = "0x1330B78", Offset = "0x1330B78", VA = "0x7BBBB30B78", Slot = "200")]
		public virtual bool RequestUsingVEM()
		{
			return default(bool);
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x0600EC87 RID: 60551 RVA: 0x000432D8 File Offset: 0x000414D8
		[Token(Token = "0x17001089")]
		public uint Oh\u0080P}]\u007F
		{
			[Token(Token = "0x600EC87")]
			[Address(RVA = "0x1331248", Offset = "0x1331248", VA = "0x7BBBB31248")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x0600EC88 RID: 60552 RVA: 0x000432F0 File Offset: 0x000414F0
		[Token(Token = "0x1700108A")]
		public Vector3 IRkQnfV
		{
			[Token(Token = "0x600EC88")]
			[Address(RVA = "0x13312E8", Offset = "0x13312E8", VA = "0x7BBBB312E8")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600EC89 RID: 60553 RVA: 0x00043308 File Offset: 0x00041508
		[Token(Token = "0x600EC89")]
		[Address(RVA = "0x13312F8", Offset = "0x13312F8", VA = "0x7BBBB312F8")]
		private bool yb\u0080U()
		{
			return default(bool);
		}

		// Token: 0x0600EC8A RID: 60554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC8A")]
		[Address(RVA = "0x12F2F14", Offset = "0x12F2F14", VA = "0x7BBBAF2F14")]
		private void KqMkDcA(LevelMovePlatform k\u007FVF\u0081^H)
		{
		}

		// Token: 0x0600EC8B RID: 60555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC8B")]
		[Address(RVA = "0x12F807C", Offset = "0x12F807C", VA = "0x7BBBAF807C")]
		private void WcyqVE}(LevelMovePlatform k\u007FVF\u0081^H)
		{
		}

		// Token: 0x0600EC8C RID: 60556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC8C")]
		[Address(RVA = "0x12FEC18", Offset = "0x12FEC18", VA = "0x7BBBAFEC18")]
		private void b\u0080~L\u0080Yw(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC8D RID: 60557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC8D")]
		[Address(RVA = "0x12FEDF0", Offset = "0x12FEDF0", VA = "0x7BBBAFEDF0")]
		private void qRe^K|D(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC8E RID: 60558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC8E")]
		[Address(RVA = "0x13097F0", Offset = "0x13097F0", VA = "0x7BBBB097F0")]
		private void p(Vector3 \u0082acFCtJ)
		{
		}

		// Token: 0x0600EC8F RID: 60559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC8F")]
		[Address(RVA = "0x12ED4A0", Offset = "0x12ED4A0", VA = "0x7BBBAED4A0")]
		public void GetOffMovePlatForm()
		{
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x0600EC90 RID: 60560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108B")]
		public Player.}Tv]tpI f\u0082Sv|E\u0081
		{
			[Token(Token = "0x600EC90")]
			[Address(RVA = "0x1331384", Offset = "0x1331384", VA = "0x7BBBB31384")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x0600EC91 RID: 60561 RVA: 0x00043320 File Offset: 0x00041520
		[Token(Token = "0x1700108C")]
		protected float m\u0081[oRJb
		{
			[Token(Token = "0x600EC91")]
			[Address(RVA = "0x133138C", Offset = "0x133138C", VA = "0x7BBBB3138C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x0600EC92 RID: 60562 RVA: 0x00043338 File Offset: 0x00041538
		[Token(Token = "0x1700108D")]
		protected float C\u0081fUCXF
		{
			[Token(Token = "0x600EC92")]
			[Address(RVA = "0x1331484", Offset = "0x1331484", VA = "0x7BBBB31484")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600EC93 RID: 60563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC93")]
		[Address(RVA = "0x1331554", Offset = "0x1331554", VA = "0x7BBBB31554", Slot = "201")]
		protected virtual void ah}\u007FiHA(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC94 RID: 60564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC94")]
		[Address(RVA = "0x13320B8", Offset = "0x13320B8", VA = "0x7BBBB320B8")]
		private void \u007FSgOFUp(bool WonLAtJ)
		{
		}

		// Token: 0x0600EC95 RID: 60565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC95")]
		[Address(RVA = "0x1301490", Offset = "0x1301490", VA = "0x7BBBB01490")]
		private void nibSJch(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC96 RID: 60566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC96")]
		[Address(RVA = "0x12FEFAC", Offset = "0x12FEFAC", VA = "0x7BBBAFEFAC")]
		private void yuc}B]g(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC97 RID: 60567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC97")]
		[Address(RVA = "0x12FF590", Offset = "0x12FF590", VA = "0x7BBBAFF590")]
		private void uoDyBeG(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC98 RID: 60568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC98")]
		[Address(RVA = "0x1300208", Offset = "0x1300208", VA = "0x7BBBB00208")]
		private void igtjccf(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC99 RID: 60569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC99")]
		[Address(RVA = "0x1301B88", Offset = "0x1301B88", VA = "0x7BBBB01B88")]
		protected void B\u0080]G{CE(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC9A RID: 60570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC9A")]
		[Address(RVA = "0x1303FF8", Offset = "0x1303FF8", VA = "0x7BBBB03FF8")]
		private void UKtgXuF(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC9B RID: 60571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC9B")]
		[Address(RVA = "0x1332BD4", Offset = "0x1332BD4", VA = "0x7BBBB32BD4")]
		private void Xu}IjR|(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC9C RID: 60572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC9C")]
		[Address(RVA = "0x12FC63C", Offset = "0x12FC63C", VA = "0x7BBBAFC63C")]
		private void uUlMllJ(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC9D RID: 60573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC9D")]
		[Address(RVA = "0x1303258", Offset = "0x1303258", VA = "0x7BBBB03258")]
		private void eN|XDa~(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC9E RID: 60574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC9E")]
		[Address(RVA = "0x13036F0", Offset = "0x13036F0", VA = "0x7BBBB036F0")]
		private void <<EMPTY_NAME>>(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600EC9F RID: 60575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC9F")]
		[Address(RVA = "0x1332EB0", Offset = "0x1332EB0", VA = "0x7BBBB32EB0")]
		public void SimOnFerrisWheel(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600ECA0 RID: 60576 RVA: 0x00043350 File Offset: 0x00041550
		[Token(Token = "0x600ECA0")]
		[Address(RVA = "0x1332EB4", Offset = "0x1332EB4", VA = "0x7BBBB32EB4")]
		public bool CanOpenParachuting(float \u0081}x[tOF)
		{
			return default(bool);
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x00043368 File Offset: 0x00041568
		[Token(Token = "0x600ECA1")]
		[Address(RVA = "0x1332F88", Offset = "0x1332F88", VA = "0x7BBBB32F88")]
		public bool IsRevivingInRebornMode()
		{
			return default(bool);
		}

		// Token: 0x0600ECA2 RID: 60578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECA2")]
		[Address(RVA = "0x133306C", Offset = "0x133306C", VA = "0x7BBBB3306C")]
		public void EnableSpeedLineEffect(bool UOhq{XI)
		{
		}

		// Token: 0x0600ECA3 RID: 60579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECA3")]
		[Address(RVA = "0x1300470", Offset = "0x1300470", VA = "0x7BBBB00470")]
		private void TXMNtr(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600ECA4 RID: 60580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECA4")]
		[Address(RVA = "0x12F1688", Offset = "0x12F1688", VA = "0x7BBBAF1688")]
		private void DABfx^^(LevelTriggerFountain Twe\u007FxUH)
		{
		}

		// Token: 0x0600ECA5 RID: 60581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECA5")]
		[Address(RVA = "0x13329F0", Offset = "0x13329F0", VA = "0x7BBBB329F0")]
		public void PostParachutingTransformChange(Transform CfvqICp)
		{
		}

		// Token: 0x0600ECA6 RID: 60582 RVA: 0x00043380 File Offset: 0x00041580
		[Token(Token = "0x600ECA6")]
		[Address(RVA = "0x13328B8", Offset = "0x13328B8", VA = "0x7BBBB328B8")]
		private bool iD{bJ[z(Vector3 DscDW`y, Vector3 LpqYir\u0082, float TeWQX\u0081J, uint awPVZCt)
		{
			return default(bool);
		}

		// Token: 0x0600ECA7 RID: 60583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECA7")]
		[Address(RVA = "0x13330FC", Offset = "0x13330FC", VA = "0x7BBBB330FC")]
		protected void ~lyNE]l()
		{
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x0600ECA8 RID: 60584 RVA: 0x00043398 File Offset: 0x00041598
		// (set) Token: 0x0600ECA9 RID: 60585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700108E")]
		public int ]dJvYUV
		{
			[Token(Token = "0x600ECA8")]
			[Address(RVA = "0x130D36C", Offset = "0x130D36C", VA = "0x7BBBB0D36C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600ECA9")]
			[Address(RVA = "0x12EC934", Offset = "0x12EC934", VA = "0x7BBBAEC934")]
			set
			{
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x0600ECAA RID: 60586 RVA: 0x000433B0 File Offset: 0x000415B0
		// (set) Token: 0x0600ECAB RID: 60587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700108F")]
		public int JxOWgVq
		{
			[Token(Token = "0x600ECAA")]
			[Address(RVA = "0x130D3CC", Offset = "0x130D3CC", VA = "0x7BBBB0D3CC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600ECAB")]
			[Address(RVA = "0x133395C", Offset = "0x133395C", VA = "0x7BBBB3395C")]
			set
			{
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x0600ECAC RID: 60588 RVA: 0x000433C8 File Offset: 0x000415C8
		// (set) Token: 0x0600ECAD RID: 60589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001090")]
		public int shmnPSl
		{
			[Token(Token = "0x600ECAC")]
			[Address(RVA = "0x13339D4", Offset = "0x13339D4", VA = "0x7BBBB339D4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600ECAD")]
			[Address(RVA = "0x1333A34", Offset = "0x1333A34", VA = "0x7BBBB33A34")]
			set
			{
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x0600ECAE RID: 60590 RVA: 0x000433E0 File Offset: 0x000415E0
		// (set) Token: 0x0600ECAF RID: 60591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001091")]
		public int gwk{H^\u0082
		{
			[Token(Token = "0x600ECAE")]
			[Address(RVA = "0x12E6E64", Offset = "0x12E6E64", VA = "0x7BBBAE6E64")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600ECAF")]
			[Address(RVA = "0x1333AAC", Offset = "0x1333AAC", VA = "0x7BBBB33AAC")]
			set
			{
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x0600ECB0 RID: 60592 RVA: 0x000433F8 File Offset: 0x000415F8
		[Token(Token = "0x17001092")]
		public int \u0081asgNNT
		{
			[Token(Token = "0x600ECB0")]
			[Address(RVA = "0x1333B24", Offset = "0x1333B24", VA = "0x7BBBB33B24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x0600ECB1 RID: 60593 RVA: 0x00043410 File Offset: 0x00041610
		[Token(Token = "0x17001093")]
		public int FbRxvZ\u0081
		{
			[Token(Token = "0x600ECB1")]
			[Address(RVA = "0x1333B88", Offset = "0x1333B88", VA = "0x7BBBB33B88")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x0600ECB2 RID: 60594 RVA: 0x00043428 File Offset: 0x00041628
		[Token(Token = "0x17001094")]
		public float reFi~^S
		{
			[Token(Token = "0x600ECB2")]
			[Address(RVA = "0x13301D0", Offset = "0x13301D0", VA = "0x7BBBB301D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x0600ECB3 RID: 60595 RVA: 0x00043440 File Offset: 0x00041640
		[Token(Token = "0x17001095")]
		public int \u0080Oj\u0082Sme
		{
			[Token(Token = "0x600ECB3")]
			[Address(RVA = "0x133300C", Offset = "0x133300C", VA = "0x7BBBB3300C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x0600ECB4 RID: 60596 RVA: 0x00043458 File Offset: 0x00041658
		// (set) Token: 0x0600ECB5 RID: 60597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001096")]
		public int m}O\u0082Jy\u0082
		{
			[Token(Token = "0x600ECB4")]
			[Address(RVA = "0x1333BF0", Offset = "0x1333BF0", VA = "0x7BBBB33BF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600ECB5")]
			[Address(RVA = "0x1333C50", Offset = "0x1333C50", VA = "0x7BBBB33C50")]
			set
			{
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x0600ECB6 RID: 60598 RVA: 0x00043470 File Offset: 0x00041670
		[Token(Token = "0x17001097")]
		public int \u0082jjlbjN
		{
			[Token(Token = "0x600ECB6")]
			[Address(RVA = "0x1333CC8", Offset = "0x1333CC8", VA = "0x7BBBB33CC8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x0600ECB7 RID: 60599 RVA: 0x00043488 File Offset: 0x00041688
		[Token(Token = "0x17001098")]
		public int Hhp\u0081\u0082|B
		{
			[Token(Token = "0x600ECB7")]
			[Address(RVA = "0x1333D28", Offset = "0x1333D28", VA = "0x7BBBB33D28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x0600ECB8 RID: 60600 RVA: 0x000434A0 File Offset: 0x000416A0
		[Token(Token = "0x17001099")]
		public bool IAS\u0081xJa
		{
			[Token(Token = "0x600ECB8")]
			[Address(RVA = "0x130E420", Offset = "0x130E420", VA = "0x7BBBB0E420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x0600ECB9 RID: 60601 RVA: 0x000434B8 File Offset: 0x000416B8
		[Token(Token = "0x1700109A")]
		public int n\u0081folTb
		{
			[Token(Token = "0x600ECB9")]
			[Address(RVA = "0x1333D88", Offset = "0x1333D88", VA = "0x7BBBB33D88")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x0600ECBA RID: 60602 RVA: 0x000434D0 File Offset: 0x000416D0
		[Token(Token = "0x1700109B")]
		public int SN\u007FWJKV
		{
			[Token(Token = "0x600ECBA")]
			[Address(RVA = "0x1333DE8", Offset = "0x1333DE8", VA = "0x7BBBB33DE8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x0600ECBB RID: 60603 RVA: 0x000434E8 File Offset: 0x000416E8
		[Token(Token = "0x1700109C")]
		public Y\u0080crNqc Ilr\u007FO}z
		{
			[Token(Token = "0x600ECBB")]
			[Address(RVA = "0x1333E48", Offset = "0x1333E48", VA = "0x7BBBB33E48")]
			get
			{
				return Y\u0080crNqc.EPLAYER_STATUS_ONLINE;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x0600ECBC RID: 60604 RVA: 0x00043500 File Offset: 0x00041700
		[Token(Token = "0x1700109D")]
		public int wnJbpNK
		{
			[Token(Token = "0x600ECBC")]
			[Address(RVA = "0x1333EA8", Offset = "0x1333EA8", VA = "0x7BBBB33EA8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x0600ECBD RID: 60605 RVA: 0x00043518 File Offset: 0x00041718
		[Token(Token = "0x1700109E")]
		public int \u0080bf\u007Ft\u0082c
		{
			[Token(Token = "0x600ECBD")]
			[Address(RVA = "0x1333F08", Offset = "0x1333F08", VA = "0x7BBBB33F08")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x0600ECBE RID: 60606 RVA: 0x00043530 File Offset: 0x00041730
		[Token(Token = "0x1700109F")]
		public byte {E\u0080isfe
		{
			[Token(Token = "0x600ECBE")]
			[Address(RVA = "0x1333F68", Offset = "0x1333F68", VA = "0x7BBBB33F68")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600ECBF RID: 60607 RVA: 0x00043548 File Offset: 0x00041748
		[Token(Token = "0x600ECBF")]
		[Address(RVA = "0x1333FCC", Offset = "0x1333FCC", VA = "0x7BBBB33FCC")]
		public sc GetStartFireState()
		{
			return sc.ESTARTFIRESTATE_NONE;
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x0600ECC0 RID: 60608 RVA: 0x00043560 File Offset: 0x00041760
		[Token(Token = "0x170010A0")]
		public int YxGhdLu
		{
			[Token(Token = "0x600ECC0")]
			[Address(RVA = "0x1333FD4", Offset = "0x1333FD4", VA = "0x7BBBB33FD4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x0600ECC1 RID: 60609 RVA: 0x00043578 File Offset: 0x00041778
		[Token(Token = "0x170010A1")]
		public int Q\u0080i\u0082q\u0081W
		{
			[Token(Token = "0x600ECC1")]
			[Address(RVA = "0x131FD44", Offset = "0x131FD44", VA = "0x7BBBB1FD44")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x0600ECC2 RID: 60610 RVA: 0x00043590 File Offset: 0x00041790
		[Token(Token = "0x170010A2")]
		public uint <<EMPTY_NAME>>
		{
			[Token(Token = "0x600ECC2")]
			[Address(RVA = "0x1334034", Offset = "0x1334034", VA = "0x7BBBB34034")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x0600ECC3 RID: 60611 RVA: 0x000435A8 File Offset: 0x000417A8
		[Token(Token = "0x170010A3")]
		public int wgc
		{
			[Token(Token = "0x600ECC3")]
			[Address(RVA = "0x1334098", Offset = "0x1334098", VA = "0x7BBBB34098")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x0600ECC4 RID: 60612 RVA: 0x000435C0 File Offset: 0x000417C0
		[Token(Token = "0x170010A4")]
		public int jcjP~Z\u007F
		{
			[Token(Token = "0x600ECC4")]
			[Address(RVA = "0x1316344", Offset = "0x1316344", VA = "0x7BBBB16344")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x0600ECC5 RID: 60613 RVA: 0x000435D8 File Offset: 0x000417D8
		[Token(Token = "0x170010A5")]
		public int \u0080AJpCnO
		{
			[Token(Token = "0x600ECC5")]
			[Address(RVA = "0x13340F8", Offset = "0x13340F8", VA = "0x7BBBB340F8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x0600ECC6 RID: 60614 RVA: 0x000435F0 File Offset: 0x000417F0
		[Token(Token = "0x170010A6")]
		public bool vwF{N{^
		{
			[Token(Token = "0x600ECC6")]
			[Address(RVA = "0x1334158", Offset = "0x1334158", VA = "0x7BBBB34158")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x0600ECC7 RID: 60615 RVA: 0x00043608 File Offset: 0x00041808
		[Token(Token = "0x170010A7")]
		public int XrM{xzg
		{
			[Token(Token = "0x600ECC7")]
			[Address(RVA = "0x12E364C", Offset = "0x12E364C", VA = "0x7BBBAE364C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x0600ECC8 RID: 60616 RVA: 0x00043620 File Offset: 0x00041820
		[Token(Token = "0x170010A8")]
		public int Y~y\u0080SGU
		{
			[Token(Token = "0x600ECC8")]
			[Address(RVA = "0x13341BC", Offset = "0x13341BC", VA = "0x7BBBB341BC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x0600ECC9 RID: 60617 RVA: 0x00043638 File Offset: 0x00041838
		[Token(Token = "0x170010A9")]
		public uint TNfAx\u007Fa
		{
			[Token(Token = "0x600ECC9")]
			[Address(RVA = "0x133421C", Offset = "0x133421C", VA = "0x7BBBB3421C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x0600ECCA RID: 60618 RVA: 0x00043650 File Offset: 0x00041850
		[Token(Token = "0x170010AA")]
		public uint gSb[KkU
		{
			[Token(Token = "0x600ECCA")]
			[Address(RVA = "0x1334280", Offset = "0x1334280", VA = "0x7BBBB34280")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600ECCB RID: 60619 RVA: 0x00043668 File Offset: 0x00041868
		[Token(Token = "0x600ECCB")]
		[Address(RVA = "0x1334288", Offset = "0x1334288", VA = "0x7BBBB34288", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600ECCC RID: 60620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECCC")]
		[Address(RVA = "0x1334290", Offset = "0x1334290", VA = "0x7BBBB34290", Slot = "20")]
		protected override void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x0600ECCD RID: 60621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECCD")]
		[Address(RVA = "0x1335D84", Offset = "0x1335D84", VA = "0x7BBBB35D84")]
		private void [m\u0081ybr\u007F(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ECCE RID: 60622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECCE")]
		[Address(RVA = "0x1335F6C", Offset = "0x1335F6C", VA = "0x7BBBB35F6C", Slot = "21")]
		protected override void OnPRIInitialized()
		{
		}

		// Token: 0x0600ECCF RID: 60623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECCF")]
		[Address(RVA = "0x1336188", Offset = "0x1336188", VA = "0x7BBBB36188", Slot = "202")]
		protected virtual void HycDFgD(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECD0 RID: 60624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD0")]
		[Address(RVA = "0x13364F8", Offset = "0x13364F8", VA = "0x7BBBB364F8", Slot = "203")]
		protected virtual void oO]Yjgx(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ECD1 RID: 60625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD1")]
		[Address(RVA = "0x13367B4", Offset = "0x13367B4", VA = "0x7BBBB367B4", Slot = "204")]
		protected virtual void lKKldMs(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECD2 RID: 60626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD2")]
		[Address(RVA = "0x1336814", Offset = "0x1336814", VA = "0x7BBBB36814", Slot = "205")]
		protected virtual void \u0080SNs\u007FVE(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x0600ECD3 RID: 60627 RVA: 0x00043680 File Offset: 0x00041880
		[Token(Token = "0x170010AB")]
		public uint tNG|jKh
		{
			[Token(Token = "0x600ECD3")]
			[Address(RVA = "0x13311E8", Offset = "0x13311E8", VA = "0x7BBBB311E8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x0600ECD4 RID: 60628 RVA: 0x00043698 File Offset: 0x00041898
		[Token(Token = "0x170010AC")]
		public float dD}~u
		{
			[Token(Token = "0x600ECD4")]
			[Address(RVA = "0x1336818", Offset = "0x1336818", VA = "0x7BBBB36818")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600ECD5 RID: 60629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD5")]
		[Address(RVA = "0x1336890", Offset = "0x1336890", VA = "0x7BBBB36890")]
		protected void BJHeCyI(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ECD6 RID: 60630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD6")]
		[Address(RVA = "0x1336A98", Offset = "0x1336A98", VA = "0x7BBBB36A98", Slot = "206")]
		protected virtual void }nJTzLX(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECD7 RID: 60631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD7")]
		[Address(RVA = "0x1336D2C", Offset = "0x1336D2C", VA = "0x7BBBB36D2C")]
		protected void [{\u0081bOTG(sbyte l]jgxbG, sbyte TzzPYjI)
		{
		}

		// Token: 0x0600ECD8 RID: 60632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD8")]
		[Address(RVA = "0x1336D68", Offset = "0x1336D68", VA = "0x7BBBB36D68")]
		protected void Gkbemmw(sbyte l]jgxbG, sbyte TzzPYjI)
		{
		}

		// Token: 0x0600ECD9 RID: 60633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECD9")]
		[Address(RVA = "0x1336DA4", Offset = "0x1336DA4", VA = "0x7BBBB36DA4")]
		protected void QXlfhia(sbyte l]jgxbG, sbyte TzzPYjI)
		{
		}

		// Token: 0x0600ECDA RID: 60634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECDA")]
		[Address(RVA = "0x1336DE0", Offset = "0x1336DE0", VA = "0x7BBBB36DE0", Slot = "207")]
		protected virtual void ^}somrQ(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECDB RID: 60635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECDB")]
		[Address(RVA = "0x13370D4", Offset = "0x13370D4", VA = "0x7BBBB370D4", Slot = "208")]
		protected virtual void Z^J{Xie(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECDC RID: 60636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECDC")]
		[Address(RVA = "0x13372DC", Offset = "0x13372DC", VA = "0x7BBBB372DC", Slot = "209")]
		protected virtual void oA~jMnp(ulong l]jgxbG, ulong TzzPYjI)
		{
		}

		// Token: 0x0600ECDD RID: 60637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECDD")]
		[Address(RVA = "0x1337BA4", Offset = "0x1337BA4", VA = "0x7BBBB37BA4", Slot = "210")]
		protected virtual void bMDvTek(ulong l]jgxbG, ulong TzzPYjI)
		{
		}

		// Token: 0x0600ECDE RID: 60638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECDE")]
		[Address(RVA = "0x1337CB0", Offset = "0x1337CB0", VA = "0x7BBBB37CB0")]
		protected void ROdti}L(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ECDF RID: 60639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECDF")]
		[Address(RVA = "0x1337D68", Offset = "0x1337D68", VA = "0x7BBBB37D68")]
		private void \u007FnKiZgk(ulong A\u0080aHuNE, ulong \u0082CQdDke)
		{
		}

		// Token: 0x0600ECE0 RID: 60640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECE0")]
		[Address(RVA = "0x1337E40", Offset = "0x1337E40", VA = "0x7BBBB37E40")]
		private void toK\u0081x(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x170010AD RID: 4269
		// (set) Token: 0x0600ECE1 RID: 60641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010AD")]
		public bool ^XMOd[T
		{
			[Token(Token = "0x600ECE1")]
			[Address(RVA = "0x1337EA0", Offset = "0x1337EA0", VA = "0x7BBBB37EA0")]
			set
			{
			}
		}

		// Token: 0x0600ECE2 RID: 60642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECE2")]
		[Address(RVA = "0x1337EAC", Offset = "0x1337EAC", VA = "0x7BBBB37EAC")]
		private void T|LO}ld(bool IltNSGB, bool \u0080~|qSSm)
		{
		}

		// Token: 0x0600ECE3 RID: 60643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECE3")]
		[Address(RVA = "0x1337FFC", Offset = "0x1337FFC", VA = "0x7BBBB37FFC")]
		private void HLFIL(bool IltNSGB, bool \u0080~|qSSm)
		{
		}

		// Token: 0x0600ECE4 RID: 60644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECE4")]
		[Address(RVA = "0x133805C", Offset = "0x133805C", VA = "0x7BBBB3805C")]
		private void x{|LkHp(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECE5 RID: 60645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECE5")]
		[Address(RVA = "0x1338754", Offset = "0x1338754", VA = "0x7BBBB38754")]
		private void c^rSFLR(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECE6 RID: 60646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECE6")]
		[Address(RVA = "0x133888C", Offset = "0x133888C", VA = "0x7BBBB3888C")]
		public void StopSighting()
		{
		}

		// Token: 0x0600ECE7 RID: 60647 RVA: 0x000436B0 File Offset: 0x000418B0
		[Token(Token = "0x600ECE7")]
		[Address(RVA = "0x1336128", Offset = "0x1336128", VA = "0x7BBBB36128")]
		public int GetKillCount()
		{
			return 0;
		}

		// Token: 0x0600ECE8 RID: 60648 RVA: 0x000436C8 File Offset: 0x000418C8
		[Token(Token = "0x600ECE8")]
		[Address(RVA = "0x1329CAC", Offset = "0x1329CAC", VA = "0x7BBBB29CAC")]
		public int GetDeathCount()
		{
			return 0;
		}

		// Token: 0x0600ECE9 RID: 60649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECE9")]
		[Address(RVA = "0x133890C", Offset = "0x133890C", VA = "0x7BBBB3890C")]
		public void OnKillCountChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECEA RID: 60650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECEA")]
		[Address(RVA = "0x1338B74", Offset = "0x1338B74", VA = "0x7BBBB38B74")]
		public void OnPlayerDeadCountChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECEB RID: 60651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECEB")]
		[Address(RVA = "0x1338E70", Offset = "0x1338E70", VA = "0x7BBBB38E70")]
		public void OnPlayerAssistCountChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECEC RID: 60652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECEC")]
		[Address(RVA = "0x13390D8", Offset = "0x13390D8", VA = "0x7BBBB390D8")]
		public void OnPlayerTotalDamageChanged(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ECED RID: 60653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECED")]
		[Address(RVA = "0x133933C", Offset = "0x133933C", VA = "0x7BBBB3933C")]
		public void OnPlayerCurCoinChanged(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECEE RID: 60654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECEE")]
		[Address(RVA = "0x133951C", Offset = "0x133951C", VA = "0x7BBBB3951C")]
		public void OnPlayerEarnedCoinChanged(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECEF RID: 60655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECEF")]
		[Address(RVA = "0x133964C", Offset = "0x133964C", VA = "0x7BBBB3964C")]
		public void OnPlayerFactionIDChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECF0 RID: 60656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF0")]
		[Address(RVA = "0x13398A4", Offset = "0x13398A4", VA = "0x7BBBB398A4")]
		public void OnPlayerODFactionChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECF1 RID: 60657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF1")]
		[Address(RVA = "0x1339A40", Offset = "0x1339A40", VA = "0x7BBBB39A40")]
		public void OnPlayerPVEKillCountChanged(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ECF2 RID: 60658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF2")]
		[Address(RVA = "0x1339AE8", Offset = "0x1339AE8", VA = "0x7BBBB39AE8")]
		public void OnPlayerThrowKnifePhaseChanged(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ECF3 RID: 60659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF3")]
		[Address(RVA = "0x1339C0C", Offset = "0x1339C0C", VA = "0x7BBBB39C0C")]
		public void OnPlayerMaxHypeChanged(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECF4 RID: 60660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF4")]
		[Address(RVA = "0x1339D44", Offset = "0x1339D44", VA = "0x7BBBB39D44")]
		public void OnPLayerMaxHypeLevelChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECF5 RID: 60661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF5")]
		[Address(RVA = "0x1339E80", Offset = "0x1339E80", VA = "0x7BBBB39E80")]
		public void OnPlayerCurHypeChanged(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECF6 RID: 60662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF6")]
		[Address(RVA = "0x133A020", Offset = "0x133A020", VA = "0x7BBBB3A020")]
		public void OnEscortTimeChanged(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECF7 RID: 60663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF7")]
		[Address(RVA = "0x133A1C0", Offset = "0x133A1C0", VA = "0x7BBBB3A1C0")]
		public void OnPlayerHypeLevelChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECF8 RID: 60664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF8")]
		[Address(RVA = "0x133AC6C", Offset = "0x133AC6C", VA = "0x7BBBB3AC6C")]
		public void OnPlayerTrainingZoneTypeIamInChanged(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ECF9 RID: 60665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECF9")]
		[Address(RVA = "0x133B0F4", Offset = "0x133B0F4", VA = "0x7BBBB3B0F4")]
		private void rN\u0081T}I}(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ECFA RID: 60666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECFA")]
		[Address(RVA = "0x133B764", Offset = "0x133B764", VA = "0x7BBBB3B764")]
		private void Usa]j]\u007F(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x000436E0 File Offset: 0x000418E0
		[Token(Token = "0x170010AE")]
		public int GP]QzTJ
		{
			[Token(Token = "0x600ECFB")]
			[Address(RVA = "0x133B90C", Offset = "0x133B90C", VA = "0x7BBBB3B90C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x000436F8 File Offset: 0x000418F8
		[Token(Token = "0x170010AF")]
		public uint HG\u007F\u0082Tjy
		{
			[Token(Token = "0x600ECFC")]
			[Address(RVA = "0x133B96C", Offset = "0x133B96C", VA = "0x7BBBB3B96C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x0600ECFD RID: 60669 RVA: 0x00043710 File Offset: 0x00041910
		[Token(Token = "0x170010B0")]
		public uint Z]H\u0082tg\u0080
		{
			[Token(Token = "0x600ECFD")]
			[Address(RVA = "0x133B9D0", Offset = "0x133B9D0", VA = "0x7BBBB3B9D0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600ECFE RID: 60670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ECFE")]
		[Address(RVA = "0x133BA30", Offset = "0x133BA30", VA = "0x7BBBB3BA30")]
		private void lqUZgJG(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600ECFF RID: 60671 RVA: 0x00043728 File Offset: 0x00041928
		[Token(Token = "0x170010B1")]
		public bool ~\u007FK\u007FuiF
		{
			[Token(Token = "0x600ECFF")]
			[Address(RVA = "0x133BA90", Offset = "0x133BA90", VA = "0x7BBBB3BA90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x0600ED00 RID: 60672 RVA: 0x00043740 File Offset: 0x00041940
		// (set) Token: 0x0600ED01 RID: 60673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010B2")]
		public bool Xxi|B^k
		{
			[Token(Token = "0x600ED00")]
			[Address(RVA = "0x12CC5D0", Offset = "0x12CC5D0", VA = "0x7BBBACC5D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ED01")]
			[Address(RVA = "0x133BAF8", Offset = "0x133BAF8", VA = "0x7BBBB3BAF8")]
			set
			{
			}
		}

		// Token: 0x0600ED02 RID: 60674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED02")]
		[Address(RVA = "0x133BB9C", Offset = "0x133BB9C", VA = "0x7BBBB3BB9C")]
		private void FC\u007FM}\u0082O(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ED03 RID: 60675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED03")]
		[Address(RVA = "0x133BD54", Offset = "0x133BD54", VA = "0x7BBBB3BD54")]
		private void [Z{CRQy(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ED04 RID: 60676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED04")]
		[Address(RVA = "0x133BEDC", Offset = "0x133BEDC", VA = "0x7BBBB3BEDC")]
		private void <<EMPTY_NAME>>(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ED05 RID: 60677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED05")]
		[Address(RVA = "0x133C078", Offset = "0x133C078", VA = "0x7BBBB3C078")]
		private void Gtwi{l[(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600ED06 RID: 60678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED06")]
		[Address(RVA = "0x133C294", Offset = "0x133C294", VA = "0x7BBBB3C294")]
		private void Sx^UY\u007Fs(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ED07 RID: 60679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED07")]
		[Address(RVA = "0x133C298", Offset = "0x133C298", VA = "0x7BBBB3C298")]
		private void \u0082SsfhEc(ulong l]jgxbG, ulong TzzPYjI)
		{
		}

		// Token: 0x0600ED08 RID: 60680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED08")]
		[Address(RVA = "0x133C5E0", Offset = "0x133C5E0", VA = "0x7BBBB3C5E0")]
		private void bcI}l\u0080{(ulong l]jgxbG, ulong TzzPYjI)
		{
		}

		// Token: 0x0600ED09 RID: 60681 RVA: 0x00043758 File Offset: 0x00041958
		[Token(Token = "0x600ED09")]
		[Address(RVA = "0x133CAF8", Offset = "0x133CAF8", VA = "0x7BBBB3CAF8")]
		private ResourceID \u0082b^Jixn()
		{
			return default(ResourceID);
		}

		// Token: 0x0600ED0A RID: 60682 RVA: 0x00043770 File Offset: 0x00041970
		[Token(Token = "0x600ED0A")]
		[Address(RVA = "0x133CBA8", Offset = "0x133CBA8", VA = "0x7BBBB3CBA8")]
		public bool ShowHandWeaponHitEffect()
		{
			return default(bool);
		}

		// Token: 0x0600ED0B RID: 60683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0B")]
		[Address(RVA = "0x133CCBC", Offset = "0x133CCBC", VA = "0x7BBBB3CCBC")]
		public void PlayHurt(ResourceID c\u0081k|Axi)
		{
		}

		// Token: 0x0600ED0C RID: 60684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0C")]
		[Address(RVA = "0x133D130", Offset = "0x133D130", VA = "0x7BBBB3D130")]
		public void PlayHeal()
		{
		}

		// Token: 0x0600ED0D RID: 60685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0D")]
		[Address(RVA = "0x133D43C", Offset = "0x133D43C", VA = "0x7BBBB3D43C")]
		public void OnPlayerInRoomChanged(bool l]jgxbG, bool TzzPYjI)
		{
		}

		// Token: 0x0600ED0E RID: 60686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0E")]
		[Address(RVA = "0x133D440", Offset = "0x133D440", VA = "0x7BBBB3D440")]
		public void OnPlayerTrainingTokenChanged(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ED0F RID: 60687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0F")]
		[Address(RVA = "0x133D7A4", Offset = "0x133D7A4", VA = "0x7BBBB3D7A4")]
		public void OnPlayerMiniGameEffectChanged(ushort l]jgxbG, ushort TzzPYjI)
		{
		}

		// Token: 0x0600ED10 RID: 60688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED10")]
		[Address(RVA = "0x133D7B8", Offset = "0x133D7B8", VA = "0x7BBBB3D7B8")]
		public void OnPlayerAmuseLevelChanged(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ED11 RID: 60689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ED11")]
		[Address(RVA = "0x133D7C4", Offset = "0x133D7C4", VA = "0x7BBBB3D7C4")]
		public List<uint> MysteryBoxQualityList()
		{
			return null;
		}

		// Token: 0x0600ED12 RID: 60690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED12")]
		[Address(RVA = "0x133D7CC", Offset = "0x133D7CC", VA = "0x7BBBB3D7CC")]
		public void OnPlayerMysteryBoxQualityChanged(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x0600ED13 RID: 60691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED13")]
		[Address(RVA = "0x133D97C", Offset = "0x133D97C", VA = "0x7BBBB3D97C")]
		public void OnPlayerPickedBountyContract(bool l]jgxbG, bool TzzPYjI)
		{
		}

		// Token: 0x0600ED14 RID: 60692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED14")]
		[Address(RVA = "0x133DBD0", Offset = "0x133DBD0", VA = "0x7BBBB3DBD0")]
		public void OnPlayerAndrewSkillEffectCountChange(uint l]jgxbG, uint TzzPYjI)
		{
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x0600ED15 RID: 60693 RVA: 0x00043788 File Offset: 0x00041988
		[Token(Token = "0x170010B3")]
		public float fgXABbp
		{
			[Token(Token = "0x600ED15")]
			[Address(RVA = "0x133DCF4", Offset = "0x133DCF4", VA = "0x7BBBB3DCF4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x0600ED16 RID: 60694 RVA: 0x000437A0 File Offset: 0x000419A0
		[Token(Token = "0x170010B4")]
		public bool IwMMpcn
		{
			[Token(Token = "0x600ED16")]
			[Address(RVA = "0x133DD5C", Offset = "0x133DD5C", VA = "0x7BBBB3DD5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x0600ED17 RID: 60695 RVA: 0x000437B8 File Offset: 0x000419B8
		[Token(Token = "0x170010B5")]
		public bool bjLg[~|
		{
			[Token(Token = "0x600ED17")]
			[Address(RVA = "0x12E2E0C", Offset = "0x12E2E0C", VA = "0x7BBBAE2E0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x0600ED18 RID: 60696 RVA: 0x000437D0 File Offset: 0x000419D0
		[Token(Token = "0x170010B6")]
		public bool y\u0082}moqQ
		{
			[Token(Token = "0x600ED18")]
			[Address(RVA = "0x12CEF90", Offset = "0x12CEF90", VA = "0x7BBBACEF90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x0600ED19 RID: 60697 RVA: 0x000437E8 File Offset: 0x000419E8
		[Token(Token = "0x170010B7")]
		public bool rYP\u0081z\u0081p
		{
			[Token(Token = "0x600ED19")]
			[Address(RVA = "0x12CEF60", Offset = "0x12CEF60", VA = "0x7BBBACEF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED1A RID: 60698 RVA: 0x00043800 File Offset: 0x00041A00
		[Token(Token = "0x600ED1A")]
		[Address(RVA = "0x133DDBC", Offset = "0x133DDBC", VA = "0x7BBBB3DDBC")]
		public Vector3 GetSyncStatePos()
		{
			return default(Vector3);
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x0600ED1B RID: 60699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ED1C RID: 60700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010B8")]
		protected dI[\u0082|T\u0080 dI[\u0082|T\u0080
		{
			[Token(Token = "0x600ED1B")]
			[Address(RVA = "0x133DE84", Offset = "0x133DE84", VA = "0x7BBBB3DE84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A7AC", Offset = "0x114A7AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600ED1C")]
			[Address(RVA = "0x133DE8C", Offset = "0x133DE8C", VA = "0x7BBBB3DE8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A7BC", Offset = "0x114A7BC")]
			set
			{
			}
		}

		// Token: 0x0600ED1D RID: 60701 RVA: 0x00043818 File Offset: 0x00041A18
		[Token(Token = "0x600ED1D")]
		[Address(RVA = "0x133DE94", Offset = "0x133DE94", VA = "0x7BBBB3DE94")]
		private bool jVuq\u0082Vk()
		{
			return default(bool);
		}

		// Token: 0x0600ED1E RID: 60702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1E")]
		[Address(RVA = "0x133DF7C", Offset = "0x133DF7C", VA = "0x7BBBB3DF7C")]
		public void InitSkateboardCd(float a\u0081HgGso, float \u0081dA]eap)
		{
		}

		// Token: 0x0600ED1F RID: 60703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1F")]
		[Address(RVA = "0x133E01C", Offset = "0x133E01C", VA = "0x7BBBB3E01C")]
		private void ^P|NklM()
		{
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x00043830 File Offset: 0x00041A30
		[Token(Token = "0x600ED20")]
		[Address(RVA = "0x133E030", Offset = "0x133E030", VA = "0x7BBBB3E030")]
		public float GetSkateboardCdSecs()
		{
			return 0f;
		}

		// Token: 0x0600ED21 RID: 60705 RVA: 0x00043848 File Offset: 0x00041A48
		[Token(Token = "0x600ED21")]
		[Address(RVA = "0x133E048", Offset = "0x133E048", VA = "0x7BBBB3E048")]
		public float GetSkateboardRemainingCdSecs()
		{
			return 0f;
		}

		// Token: 0x0600ED22 RID: 60706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED22")]
		[Address(RVA = "0x133E060", Offset = "0x133E060", VA = "0x7BBBB3E060")]
		private void ]A\u007Fydsd()
		{
		}

		// Token: 0x0600ED23 RID: 60707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED23")]
		[Address(RVA = "0x133E18C", Offset = "0x133E18C", VA = "0x7BBBB3E18C")]
		public void RequestStartSkateboarding()
		{
		}

		// Token: 0x0600ED24 RID: 60708 RVA: 0x00043860 File Offset: 0x00041A60
		[Token(Token = "0x600ED24")]
		[Address(RVA = "0x133E3C8", Offset = "0x133E3C8", VA = "0x7BBBB3E3C8")]
		private bool ~bDo~V[()
		{
			return default(bool);
		}

		// Token: 0x0600ED25 RID: 60709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED25")]
		[Address(RVA = "0x133EB0C", Offset = "0x133EB0C", VA = "0x7BBBB3EB0C")]
		public void RequestStopSkateboarding()
		{
		}

		// Token: 0x0600ED26 RID: 60710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED26")]
		[Address(RVA = "0x133E098", Offset = "0x133E098", VA = "0x7BBBB3E098")]
		public void RequestStopSkateboarding(bi O\u0080[pV^Y)
		{
		}

		// Token: 0x0600ED27 RID: 60711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED27")]
		[Address(RVA = "0x133EAE0", Offset = "0x133EAE0", VA = "0x7BBBB3EAE0")]
		public void OnGetOnSkateboard(bi O\u0080[pV^Y)
		{
		}

		// Token: 0x0600ED28 RID: 60712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED28")]
		[Address(RVA = "0x133EB14", Offset = "0x133EB14", VA = "0x7BBBB3EB14")]
		public void OnGetOffSkateboard(bi O\u0080[pV^Y)
		{
		}

		// Token: 0x0600ED29 RID: 60713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED29")]
		[Address(RVA = "0x133EBF8", Offset = "0x133EBF8", VA = "0x7BBBB3EBF8")]
		protected void i\u0082LFi\u0080^()
		{
		}

		// Token: 0x0600ED2A RID: 60714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED2A")]
		[Address(RVA = "0x12ECDD0", Offset = "0x12ECDD0", VA = "0x7BBBAECDD0")]
		protected void uXfMHy^()
		{
		}

		// Token: 0x0600ED2B RID: 60715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED2B")]
		[Address(RVA = "0x133F058", Offset = "0x133F058", VA = "0x7BBBB3F058")]
		private void IgLHYRL()
		{
		}

		// Token: 0x0600ED2C RID: 60716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED2C")]
		[Address(RVA = "0x133FD5C", Offset = "0x133FD5C", VA = "0x7BBBB3FD5C")]
		private void MGv\u0080onM()
		{
		}

		// Token: 0x0600ED2D RID: 60717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED2D")]
		[Address(RVA = "0x133F778", Offset = "0x133F778", VA = "0x7BBBB3F778")]
		private void iahdHKh(bool wqTuwxJ)
		{
		}

		// Token: 0x0600ED2E RID: 60718 RVA: 0x00043878 File Offset: 0x00041A78
		[Token(Token = "0x600ED2E")]
		[Address(RVA = "0x133FECC", Offset = "0x133FECC", VA = "0x7BBBB3FECC")]
		private static bool tMRZG\u0082X(GameObject OvVn`fc, bool wqTuwxJ)
		{
			return default(bool);
		}

		// Token: 0x0600ED2F RID: 60719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED2F")]
		[Address(RVA = "0x133EE9C", Offset = "0x133EE9C", VA = "0x7BBBB3EE9C")]
		protected void RO}oIXY(bool wqTuwxJ)
		{
		}

		// Token: 0x0600ED30 RID: 60720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED30")]
		[Address(RVA = "0x133EF9C", Offset = "0x133EF9C", VA = "0x7BBBB3EF9C")]
		private void ZoKDxxC(bool \u007FuesYwp)
		{
		}

		// Token: 0x0600ED31 RID: 60721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED31")]
		[Address(RVA = "0x133F520", Offset = "0x133F520", VA = "0x7BBBB3F520")]
		private void ]memFdN()
		{
		}

		// Token: 0x0600ED32 RID: 60722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED32")]
		[Address(RVA = "0x133F5EC", Offset = "0x133F5EC", VA = "0x7BBBB3F5EC")]
		public void SetupSkateboardCamera()
		{
		}

		// Token: 0x0600ED33 RID: 60723 RVA: 0x00043890 File Offset: 0x00041A90
		[Token(Token = "0x600ED33")]
		[Address(RVA = "0x1340300", Offset = "0x1340300", VA = "0x7BBBB40300")]
		public bool CanSkateboardJump()
		{
			return default(bool);
		}

		// Token: 0x0600ED34 RID: 60724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED34")]
		[Address(RVA = "0x1340488", Offset = "0x1340488", VA = "0x7BBBB40488")]
		public void RequestSkateboardJump()
		{
		}

		// Token: 0x0600ED35 RID: 60725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED35")]
		[Address(RVA = "0x1340530", Offset = "0x1340530", VA = "0x7BBBB40530")]
		public void OnSkateboardJump()
		{
		}

		// Token: 0x0600ED36 RID: 60726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED36")]
		[Address(RVA = "0x1340658", Offset = "0x1340658", VA = "0x7BBBB40658")]
		private void rijbCki()
		{
		}

		// Token: 0x0600ED37 RID: 60727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED37")]
		[Address(RVA = "0x1340838", Offset = "0x1340838", VA = "0x7BBBB40838")]
		private void YJxB}qK()
		{
		}

		// Token: 0x0600ED38 RID: 60728 RVA: 0x000438A8 File Offset: 0x00041AA8
		[Token(Token = "0x600ED38")]
		[Address(RVA = "0x1340914", Offset = "0x1340914", VA = "0x7BBBB40914")]
		public float GetSkateboardJumpCdSecs()
		{
			return 0f;
		}

		// Token: 0x0600ED39 RID: 60729 RVA: 0x000438C0 File Offset: 0x00041AC0
		[Token(Token = "0x600ED39")]
		[Address(RVA = "0x134092C", Offset = "0x134092C", VA = "0x7BBBB4092C")]
		public float GetSkateboardJumpRemainingCdSecs()
		{
			return 0f;
		}

		// Token: 0x0600ED3A RID: 60730 RVA: 0x000438D8 File Offset: 0x00041AD8
		[Token(Token = "0x600ED3A")]
		[Address(RVA = "0x1340944", Offset = "0x1340944", VA = "0x7BBBB40944")]
		public bool CanSkateboardDash()
		{
			return default(bool);
		}

		// Token: 0x0600ED3B RID: 60731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED3B")]
		[Address(RVA = "0x1340980", Offset = "0x1340980", VA = "0x7BBBB40980")]
		public void RequestSkateboardDash()
		{
		}

		// Token: 0x0600ED3C RID: 60732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED3C")]
		[Address(RVA = "0x1340B74", Offset = "0x1340B74", VA = "0x7BBBB40B74")]
		public void OnStateboardDash()
		{
		}

		// Token: 0x0600ED3D RID: 60733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED3D")]
		[Address(RVA = "0x134051C", Offset = "0x134051C", VA = "0x7BBBB4051C")]
		private void kE}E()
		{
		}

		// Token: 0x0600ED3E RID: 60734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED3E")]
		[Address(RVA = "0x1340C30", Offset = "0x1340C30", VA = "0x7BBBB40C30")]
		private void WbFG~GM()
		{
		}

		// Token: 0x0600ED3F RID: 60735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED3F")]
		[Address(RVA = "0x1340ACC", Offset = "0x1340ACC", VA = "0x7BBBB40ACC")]
		private void v\u0080LJgku()
		{
		}

		// Token: 0x0600ED40 RID: 60736 RVA: 0x000438F0 File Offset: 0x00041AF0
		[Token(Token = "0x600ED40")]
		[Address(RVA = "0x1340CFC", Offset = "0x1340CFC", VA = "0x7BBBB40CFC")]
		public float GetSkateboardDashRemainingCdSecs()
		{
			return 0f;
		}

		// Token: 0x0600ED41 RID: 60737 RVA: 0x00043908 File Offset: 0x00041B08
		[Token(Token = "0x600ED41")]
		[Address(RVA = "0x1340D14", Offset = "0x1340D14", VA = "0x7BBBB40D14")]
		public float GetSkateboardDashCdSecs()
		{
			return 0f;
		}

		// Token: 0x0600ED42 RID: 60738 RVA: 0x00043920 File Offset: 0x00041B20
		[Token(Token = "0x600ED42")]
		[Address(RVA = "0x1340D2C", Offset = "0x1340D2C", VA = "0x7BBBB40D2C")]
		private bool E\u007FwTzq\u0082()
		{
			return default(bool);
		}

		// Token: 0x0600ED43 RID: 60739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED43")]
		[Address(RVA = "0x13046AC", Offset = "0x13046AC", VA = "0x7BBBB046AC")]
		private void qIfKfK\u0080(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600ED44 RID: 60740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED44")]
		[Address(RVA = "0x1340D5C", Offset = "0x1340D5C", VA = "0x7BBBB40D5C")]
		protected void M\u0082XKk^o(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600ED45 RID: 60741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED45")]
		[Address(RVA = "0x1341414", Offset = "0x1341414", VA = "0x7BBBB41414")]
		protected void PwcFmSR()
		{
		}

		// Token: 0x0600ED46 RID: 60742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED46")]
		[Address(RVA = "0x13416C8", Offset = "0x13416C8", VA = "0x7BBBB416C8")]
		protected void Pf\u007Frq[^()
		{
		}

		// Token: 0x0600ED47 RID: 60743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED47")]
		[Address(RVA = "0x1341658", Offset = "0x1341658", VA = "0x7BBBB41658")]
		protected void cTiJHE|(out bool |eUD\u0082XC, out bool c\u0080gZkpi)
		{
		}

		// Token: 0x0600ED48 RID: 60744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED48")]
		[Address(RVA = "0x133E338", Offset = "0x133E338", VA = "0x7BBBB3E338")]
		private void TmkvRP|()
		{
		}

		// Token: 0x0600ED49 RID: 60745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED49")]
		[Address(RVA = "0x133E380", Offset = "0x133E380", VA = "0x7BBBB3E380")]
		private void rcPBO~I()
		{
		}

		// Token: 0x0600ED4A RID: 60746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED4A")]
		[Address(RVA = "0x133EA98", Offset = "0x133EA98", VA = "0x7BBBB3EA98")]
		private void fmddmMx()
		{
		}

		// Token: 0x0600ED4B RID: 60747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED4B")]
		[Address(RVA = "0x1340A84", Offset = "0x1340A84", VA = "0x7BBBB40A84")]
		private void iNQkF}a()
		{
		}

		// Token: 0x0600ED4C RID: 60748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED4C")]
		[Address(RVA = "0x1340440", Offset = "0x1340440", VA = "0x7BBBB40440")]
		private void eYddCfP()
		{
		}

		// Token: 0x0600ED4D RID: 60749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED4D")]
		[Address(RVA = "0x133EBB0", Offset = "0x133EBB0", VA = "0x7BBBB3EBB0")]
		private void DVkKN}]()
		{
		}

		// Token: 0x0600ED4E RID: 60750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED4E")]
		[Address(RVA = "0x133D634", Offset = "0x133D634", VA = "0x7BBBB3D634")]
		private void UDV(string nvOf`b\u007F)
		{
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x0600ED4F RID: 60751 RVA: 0x00043938 File Offset: 0x00041B38
		[Token(Token = "0x170010B9")]
		public bool avkBJz\u0080
		{
			[Token(Token = "0x600ED4F")]
			[Address(RVA = "0x12CEF10", Offset = "0x12CEF10", VA = "0x7BBBACEF10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x0600ED50 RID: 60752 RVA: 0x00043950 File Offset: 0x00041B50
		[Token(Token = "0x170010BA")]
		public bool q
		{
			[Token(Token = "0x600ED50")]
			[Address(RVA = "0x13417C0", Offset = "0x13417C0", VA = "0x7BBBB417C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x0600ED51 RID: 60753 RVA: 0x00043968 File Offset: 0x00041B68
		[Token(Token = "0x170010BB")]
		public bool |eEYLTf
		{
			[Token(Token = "0x600ED51")]
			[Address(RVA = "0x1341850", Offset = "0x1341850", VA = "0x7BBBB41850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED52 RID: 60754 RVA: 0x00043980 File Offset: 0x00041B80
		[Token(Token = "0x600ED52")]
		[Address(RVA = "0x13418E0", Offset = "0x13418E0", VA = "0x7BBBB418E0", Slot = "211")]
		public virtual bool RequestSkySurfing()
		{
			return default(bool);
		}

		// Token: 0x0600ED53 RID: 60755 RVA: 0x00043998 File Offset: 0x00041B98
		[Token(Token = "0x600ED53")]
		[Address(RVA = "0x13419D8", Offset = "0x13419D8", VA = "0x7BBBB419D8", Slot = "212")]
		public virtual bool RequestSkyDiving()
		{
			return default(bool);
		}

		// Token: 0x0600ED54 RID: 60756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED54")]
		[Address(RVA = "0x1341A44", Offset = "0x1341A44", VA = "0x7BBBB41A44")]
		private void CJg\u007FaLV()
		{
		}

		// Token: 0x0600ED55 RID: 60757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED55")]
		[Address(RVA = "0x12E97C4", Offset = "0x12E97C4", VA = "0x7BBBAE97C4")]
		public void InitStatus(Player.T[m JXT\u0081\u0080QL, VCDxuoO wlEMBeh)
		{
		}

		// Token: 0x0600ED56 RID: 60758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED56")]
		[Address(RVA = "0x1341E44", Offset = "0x1341E44", VA = "0x7BBBB41E44", Slot = "213")]
		public virtual void SwitchPhysXState(Player.T[m JXT\u0081\u0080QL, VCDxuoO wlEMBeh = VCDxuoO.EPHYSXPOSE_STANDING)
		{
		}

		// Token: 0x0600ED57 RID: 60759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED57")]
		[Address(RVA = "0x1342300", Offset = "0x1342300", VA = "0x7BBBB42300")]
		protected void ErmLSJy(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ, Player.T[m JXT\u0081\u0080QL, VCDxuoO wlEMBeh)
		{
		}

		// Token: 0x0600ED58 RID: 60760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED58")]
		[Address(RVA = "0x12E2CFC", Offset = "0x12E2CFC", VA = "0x7BBBAE2CFC")]
		public void CheckAuxAimStatusChanged()
		{
		}

		// Token: 0x0600ED59 RID: 60761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED59")]
		[Address(RVA = "0x12EC7A0", Offset = "0x12EC7A0", VA = "0x7BBBAEC7A0")]
		private void dmiokEK(bool JcGNLII)
		{
		}

		// Token: 0x0600ED5A RID: 60762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED5A")]
		[Address(RVA = "0x13423FC", Offset = "0x13423FC", VA = "0x7BBBB423FC")]
		private void wAqCMGL(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ, Player.T[m JXT\u0081\u0080QL, VCDxuoO wlEMBeh)
		{
		}

		// Token: 0x0600ED5B RID: 60763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED5B")]
		[Address(RVA = "0x13425FC", Offset = "0x13425FC", VA = "0x7BBBB425FC", Slot = "214")]
		public virtual void SwitchPhysXPose(VCDxuoO |Dc\u0080arn)
		{
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x0600ED5C RID: 60764 RVA: 0x000439B0 File Offset: 0x00041BB0
		[Token(Token = "0x170010BC")]
		public bool ~tF~ic[
		{
			[Token(Token = "0x600ED5C")]
			[Address(RVA = "0x12CA2AC", Offset = "0x12CA2AC", VA = "0x7BBBACA2AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x0600ED5D RID: 60765 RVA: 0x000439C8 File Offset: 0x00041BC8
		[Token(Token = "0x170010BD")]
		public bool w[nqpt[
		{
			[Token(Token = "0x600ED5D")]
			[Address(RVA = "0x12C96F4", Offset = "0x12C96F4", VA = "0x7BBBAC96F4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x0600ED5E RID: 60766 RVA: 0x000439E0 File Offset: 0x00041BE0
		[Token(Token = "0x170010BE")]
		private bool lZO]k^
		{
			[Token(Token = "0x600ED5E")]
			[Address(RVA = "0x1332690", Offset = "0x1332690", VA = "0x7BBBB32690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x0600ED5F RID: 60767 RVA: 0x000439F8 File Offset: 0x00041BF8
		[Token(Token = "0x170010BF")]
		public bool pPj{CwT
		{
			[Token(Token = "0x600ED5F")]
			[Address(RVA = "0x12CEF5C", Offset = "0x12CEF5C", VA = "0x7BBBACEF5C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x0600ED60 RID: 60768 RVA: 0x00043A10 File Offset: 0x00041C10
		[Token(Token = "0x170010C0")]
		private bool cUmrFC
		{
			[Token(Token = "0x600ED60")]
			[Address(RVA = "0x1342658", Offset = "0x1342658", VA = "0x7BBBB42658")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x0600ED61 RID: 60769 RVA: 0x00043A28 File Offset: 0x00041C28
		[Token(Token = "0x170010C1")]
		public bool vZNUFHA
		{
			[Token(Token = "0x600ED61")]
			[Address(RVA = "0x12CA2E8", Offset = "0x12CA2E8", VA = "0x7BBBACA2E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED62 RID: 60770 RVA: 0x00043A40 File Offset: 0x00041C40
		[Token(Token = "0x600ED62")]
		[Address(RVA = "0x1342688", Offset = "0x1342688", VA = "0x7BBBB42688", Slot = "215")]
		public virtual bool RequestStartSwimmingSurfing()
		{
			return default(bool);
		}

		// Token: 0x0600ED63 RID: 60771 RVA: 0x00043A58 File Offset: 0x00041C58
		[Token(Token = "0x600ED63")]
		[Address(RVA = "0x13426B0", Offset = "0x13426B0", VA = "0x7BBBB426B0", Slot = "216")]
		public virtual bool RequestStopSwimmingSurfing()
		{
			return default(bool);
		}

		// Token: 0x0600ED64 RID: 60772 RVA: 0x00043A70 File Offset: 0x00041C70
		[Token(Token = "0x600ED64")]
		[Address(RVA = "0x13426D8", Offset = "0x13426D8", VA = "0x7BBBB426D8", Slot = "217")]
		public virtual bool RequestStartSwimming()
		{
			return default(bool);
		}

		// Token: 0x0600ED65 RID: 60773 RVA: 0x00043A88 File Offset: 0x00041C88
		[Token(Token = "0x600ED65")]
		[Address(RVA = "0x13427A0", Offset = "0x13427A0", VA = "0x7BBBB427A0", Slot = "218")]
		public virtual bool RequestStopSwimming()
		{
			return default(bool);
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x0600ED66 RID: 60774 RVA: 0x00043AA0 File Offset: 0x00041CA0
		[Token(Token = "0x170010C2")]
		public {QAb\u0082~u vqsSd~k
		{
			[Token(Token = "0x600ED66")]
			[Address(RVA = "0x134289C", Offset = "0x134289C", VA = "0x7BBBB4289C")]
			get
			{
				return default({QAb\u0082~u);
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x0600ED67 RID: 60775 RVA: 0x00043AB8 File Offset: 0x00041CB8
		[Token(Token = "0x170010C3")]
		public byte y\u0081VwuLL
		{
			[Token(Token = "0x600ED67")]
			[Address(RVA = "0x13428B4", Offset = "0x13428B4", VA = "0x7BBBB428B4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x0600ED68 RID: 60776 RVA: 0x00043AD0 File Offset: 0x00041CD0
		[Token(Token = "0x170010C4")]
		public kd[\u0080AVO IIqBnJi
		{
			[Token(Token = "0x600ED68")]
			[Address(RVA = "0x1314A68", Offset = "0x1314A68", VA = "0x7BBBB14A68")]
			get
			{
				return kd[\u0080AVO.EParachuteMode_Free;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x0600ED69 RID: 60777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C5")]
		public Transform eW~d}gn
		{
			[Token(Token = "0x600ED69")]
			[Address(RVA = "0x13428BC", Offset = "0x13428BC", VA = "0x7BBBB428BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ED6A RID: 60778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6A")]
		[Address(RVA = "0x1342960", Offset = "0x1342960", VA = "0x7BBBB42960")]
		public void InitTeamParachuteInfo(object ldzAD`u)
		{
		}

		// Token: 0x0600ED6B RID: 60779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6B")]
		[Address(RVA = "0x1342AAC", Offset = "0x1342AAC", VA = "0x7BBBB42AAC")]
		public void SetTeamParachuteLeaderID({QAb\u0082~u mB[J}YY)
		{
		}

		// Token: 0x0600ED6C RID: 60780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6C")]
		[Address(RVA = "0x1342BF8", Offset = "0x1342BF8", VA = "0x7BBBB42BF8")]
		private void DEZwc[R({QAb\u0082~u u`TeWAG)
		{
		}

		// Token: 0x0600ED6D RID: 60781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6D")]
		[Address(RVA = "0x1342EA4", Offset = "0x1342EA4", VA = "0x7BBBB42EA4")]
		public void OnBecomeFree()
		{
		}

		// Token: 0x0600ED6E RID: 60782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6E")]
		[Address(RVA = "0x1343198", Offset = "0x1343198", VA = "0x7BBBB43198")]
		public void OnBecomeLeader()
		{
		}

		// Token: 0x0600ED6F RID: 60783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6F")]
		[Address(RVA = "0x1343424", Offset = "0x1343424", VA = "0x7BBBB43424")]
		public void OnBecomeFollower()
		{
		}

		// Token: 0x0600ED70 RID: 60784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED70")]
		[Address(RVA = "0x13326C0", Offset = "0x13326C0", VA = "0x7BBBB326C0")]
		private void ~ILB^o\u007F(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600ED71 RID: 60785 RVA: 0x00043AE8 File Offset: 0x00041CE8
		[Token(Token = "0x600ED71")]
		[Address(RVA = "0x13437A8", Offset = "0x13437A8", VA = "0x7BBBB437A8")]
		private bool GFNDRvP(Vector3 DscDW`y, Vector3 \u0081cWZx[U)
		{
			return default(bool);
		}

		// Token: 0x0600ED72 RID: 60786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED72")]
		[Address(RVA = "0x1343128", Offset = "0x1343128", VA = "0x7BBBB43128")]
		private void rm^k~[f()
		{
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600ED73 RID: 60787 RVA: 0x00043B00 File Offset: 0x00041D00
		[Token(Token = "0x170010C6")]
		public bool rf\u0082tp]q
		{
			[Token(Token = "0x600ED73")]
			[Address(RVA = "0x1332BA4", Offset = "0x1332BA4", VA = "0x7BBBB32BA4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED74 RID: 60788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED74")]
		[Address(RVA = "0x1343A58", Offset = "0x1343A58", VA = "0x7BBBB43A58")]
		public void ClientForceBecomeFreeMode()
		{
		}

		// Token: 0x0600ED75 RID: 60789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED75")]
		[Address(RVA = "0x1343B08", Offset = "0x1343B08", VA = "0x7BBBB43B08")]
		public void NotifyServerParachuteFree()
		{
		}

		// Token: 0x0600ED76 RID: 60790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED76")]
		[Address(RVA = "0x1343BB0", Offset = "0x1343BB0", VA = "0x7BBBB43BB0")]
		public void NotifyServerTransferLeader({QAb\u0082~u mB[J}YY)
		{
		}

		// Token: 0x0600ED77 RID: 60791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED77")]
		[Address(RVA = "0x1343DA4", Offset = "0x1343DA4", VA = "0x7BBBB43DA4")]
		public void NotifyServerFollowLeader()
		{
		}

		// Token: 0x0600ED78 RID: 60792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED78")]
		[Address(RVA = "0x1343F28", Offset = "0x1343F28", VA = "0x7BBBB43F28")]
		public void OnServerTransferLeaderFail()
		{
		}

		// Token: 0x0600ED79 RID: 60793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED79")]
		[Address(RVA = "0x13440AC", Offset = "0x13440AC", VA = "0x7BBBB440AC")]
		public void OnServerFollowLeaderFail()
		{
		}

		// Token: 0x0600ED7A RID: 60794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7A")]
		[Address(RVA = "0x1314C94", Offset = "0x1314C94", VA = "0x7BBBB14C94")]
		public void ShowParachuteActionBtn()
		{
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x0600ED7B RID: 60795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C7")]
		public JECPJUw gg\u0082u\u0081bn
		{
			[Token(Token = "0x600ED7B")]
			[Address(RVA = "0x1329768", Offset = "0x1329768", VA = "0x7BBBB29768")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ED7C RID: 60796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7C")]
		[Address(RVA = "0x1344230", Offset = "0x1344230", VA = "0x7BBBB44230", Slot = "219")]
		public virtual void RequestTransform(ResourceID jMB[Gx\u007F)
		{
		}

		// Token: 0x0600ED7D RID: 60797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7D")]
		[Address(RVA = "0x1344238", Offset = "0x1344238", VA = "0x7BBBB44238")]
		public void EnterTransform(ResourceID jMB[Gx\u007F)
		{
		}

		// Token: 0x0600ED7E RID: 60798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7E")]
		[Address(RVA = "0x1344314", Offset = "0x1344314", VA = "0x7BBBB44314")]
		public void EnterTransform(GameObject Z~czXgW)
		{
		}

		// Token: 0x0600ED7F RID: 60799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7F")]
		[Address(RVA = "0x1344640", Offset = "0x1344640", VA = "0x7BBBB44640", Slot = "220")]
		protected virtual void \u0082fbgt]\u0081(JECPJUw whqcWqF)
		{
		}

		// Token: 0x0600ED80 RID: 60800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED80")]
		[Address(RVA = "0x1344794", Offset = "0x1344794", VA = "0x7BBBB44794", Slot = "221")]
		protected virtual void zhJRf\u0081b(JECPJUw whqcWqF)
		{
		}

		// Token: 0x0600ED81 RID: 60801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED81")]
		[Address(RVA = "0x1344798", Offset = "0x1344798", VA = "0x7BBBB44798", Slot = "222")]
		public virtual void RequestExitTransform()
		{
		}

		// Token: 0x0600ED82 RID: 60802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED82")]
		[Address(RVA = "0x134479C", Offset = "0x134479C", VA = "0x7BBBB4479C")]
		public void ExitTransform()
		{
		}

		// Token: 0x0600ED83 RID: 60803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED83")]
		[Address(RVA = "0x13448A0", Offset = "0x13448A0", VA = "0x7BBBB448A0", Slot = "223")]
		protected virtual void MZah\u0082cM()
		{
		}

		// Token: 0x0600ED84 RID: 60804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED84")]
		[Address(RVA = "0x1344600", Offset = "0x1344600", VA = "0x7BBBB44600")]
		public void SetOrgModelVisible(bool hjuXXOK)
		{
		}

		// Token: 0x0600ED86 RID: 60806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED86")]
		[Address(RVA = "0x134491C", Offset = "0x134491C", VA = "0x7BBBB4491C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A7CC", Offset = "0x114A7CC")]
		private void drLaAEe()
		{
		}

		// Token: 0x040113CC RID: 70604
		[Token(Token = "0x40113CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Player.E[OnOQS PiBm\u0081KG;

		// Token: 0x040113CD RID: 70605
		[Token(Token = "0x40113CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Dictionary<{QAb\u0082~u, Player.E[OnOQS> VPxEioq;

		// Token: 0x040113CE RID: 70606
		[Token(Token = "0x40113CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected GameObject ccil^Pm;

		// Token: 0x040113CF RID: 70607
		[Token(Token = "0x40113CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected ResourceID I~SVGJ};

		// Token: 0x040113D0 RID: 70608
		[Token(Token = "0x40113D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected GameObject Jnk;

		// Token: 0x040113D1 RID: 70609
		[Token(Token = "0x40113D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected ResourceID wtqogCx;

		// Token: 0x040113D2 RID: 70610
		[Token(Token = "0x40113D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected GameObject VId\u0080gSg;

		// Token: 0x040113D3 RID: 70611
		[Token(Token = "0x40113D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<uint, int> gEdUxD;

		// Token: 0x040113D4 RID: 70612
		[Token(Token = "0x40113D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<int, GameObject> yCTQFjw;

		// Token: 0x040113D5 RID: 70613
		[Token(Token = "0x40113D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private EmoteLeaderCollider alJL^bk;

		// Token: 0x040113D6 RID: 70614
		[Token(Token = "0x40113D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected bool v|jb}|u;

		// Token: 0x040113D7 RID: 70615
		[Token(Token = "0x40113D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool TPAHSnv;

		// Token: 0x040113D8 RID: 70616
		[Token(Token = "0x40113D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Transform MainCameraTransform;

		// Token: 0x040113D9 RID: 70617
		[Token(Token = "0x40113D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Player.Nn H\u007FeWICj;

		// Token: 0x040113DA RID: 70618
		[Token(Token = "0x40113DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private uint Sdx}]mB;

		// Token: 0x040113DB RID: 70619
		[Token(Token = "0x40113DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected ulong K{HbwTy;

		// Token: 0x040113DC RID: 70620
		[Token(Token = "0x40113DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected {QAb\u0082~u [^[KJuA;

		// Token: 0x040113DD RID: 70621
		[Token(Token = "0x40113DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected ulong \u0082gpofs\u0080;

		// Token: 0x040113DE RID: 70622
		[Token(Token = "0x40113DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11314F4", Offset = "0x11314F4")]
		private int <NeRvlI\u0081>k__BackingField;

		// Token: 0x040113DF RID: 70623
		[Token(Token = "0x40113DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public uint TeamModeID;

		// Token: 0x040113E0 RID: 70624
		[Token(Token = "0x40113E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool IsShowEquip;

		// Token: 0x040113E1 RID: 70625
		[Token(Token = "0x40113E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131504", Offset = "0x1131504")]
		private {QAb\u0082~u <H|\u0082Xsqq>k__BackingField;

		// Token: 0x040113E2 RID: 70626
		[Token(Token = "0x40113E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131514", Offset = "0x1131514")]
		private uint <Hwz}fqg>k__BackingField;

		// Token: 0x040113E3 RID: 70627
		[Token(Token = "0x40113E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131524", Offset = "0x1131524")]
		private string <yJTDZyl>k__BackingField;

		// Token: 0x040113E4 RID: 70628
		[Token(Token = "0x40113E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131534", Offset = "0x1131534")]
		private string <\u0081j]oC[W>k__BackingField;

		// Token: 0x040113E5 RID: 70629
		[Token(Token = "0x40113E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131544", Offset = "0x1131544")]
		private uint <bPL]zQM>k__BackingField;

		// Token: 0x040113E6 RID: 70630
		[Token(Token = "0x40113E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected object pNLijU|;

		// Token: 0x040113E7 RID: 70631
		[Token(Token = "0x40113E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected string OciE~Hn;

		// Token: 0x040113E8 RID: 70632
		[Token(Token = "0x40113E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool IsClientBot;

		// Token: 0x040113E9 RID: 70633
		[Token(Token = "0x40113E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		protected bool IBmAirC;

		// Token: 0x040113EA RID: 70634
		[Token(Token = "0x40113EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131554", Offset = "0x1131554")]
		private bool <n]NAFKC>k__BackingField;

		// Token: 0x040113EB RID: 70635
		[Token(Token = "0x40113EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		protected TBlackBoard SoK\u0080FzB;

		// Token: 0x040113EC RID: 70636
		[Token(Token = "0x40113EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected UserControlHandler LHE~Nq{;

		// Token: 0x040113ED RID: 70637
		[Token(Token = "0x40113ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected CharacterController zoJf[H|;

		// Token: 0x040113EE RID: 70638
		[Token(Token = "0x40113EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool D\u007FLsPfr;

		// Token: 0x040113EF RID: 70639
		[Token(Token = "0x40113EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		private bool yoZJhug;

		// Token: 0x040113F0 RID: 70640
		[Token(Token = "0x40113F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		protected uint zvkppf[;

		// Token: 0x040113F1 RID: 70641
		[Token(Token = "0x40113F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		protected bool MdZCJjU;

		// Token: 0x040113F2 RID: 70642
		[Token(Token = "0x40113F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		protected uint AYi~zos;

		// Token: 0x040113F3 RID: 70643
		[Token(Token = "0x40113F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131564", Offset = "0x1131564")]
		private bool <eNPeR\u0081W>k__BackingField;

		// Token: 0x040113F4 RID: 70644
		[Token(Token = "0x40113F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131574", Offset = "0x1131574")]
		private bool <s\u0082tXkzG>k__BackingField;

		// Token: 0x040113F5 RID: 70645
		[Token(Token = "0x40113F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131584", Offset = "0x1131584")]
		private bool <IhEe}KL>k__BackingField;

		// Token: 0x040113F6 RID: 70646
		[Token(Token = "0x40113F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131594", Offset = "0x1131594")]
		private bool <cC}]Swk>k__BackingField;

		// Token: 0x040113F7 RID: 70647
		[Token(Token = "0x40113F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11315A4", Offset = "0x11315A4")]
		private bool <NEK^x\u007FM>k__BackingField;

		// Token: 0x040113F8 RID: 70648
		[Token(Token = "0x40113F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected LevelAmmoBox elTRKJ};

		// Token: 0x040113F9 RID: 70649
		[Token(Token = "0x40113F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11315B4", Offset = "0x11315B4")]
		private uint <WJM\u0082NDb>k__BackingField;

		// Token: 0x040113FA RID: 70650
		[Token(Token = "0x40113FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public Vector3 TeamMapMark;

		// Token: 0x040113FB RID: 70651
		[Token(Token = "0x40113FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool ShowMapMark;

		// Token: 0x040113FC RID: 70652
		[Token(Token = "0x40113FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public uint CachedLastDriveVehicleObjID;

		// Token: 0x040113FD RID: 70653
		[Token(Token = "0x40113FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public float InCount;

		// Token: 0x040113FE RID: 70654
		[Token(Token = "0x40113FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public float UnCount;

		// Token: 0x040113FF RID: 70655
		[Token(Token = "0x40113FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public uint GetCount;

		// Token: 0x04011400 RID: 70656
		[Token(Token = "0x4011400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		public uint AimCount;

		// Token: 0x04011401 RID: 70657
		[Token(Token = "0x4011401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Quaternion Z\u0081MVsBB;

		// Token: 0x04011402 RID: 70658
		[Token(Token = "0x4011402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public float Speed;

		// Token: 0x04011403 RID: 70659
		[Token(Token = "0x4011403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private float \u0082Nrqa|F;

		// Token: 0x04011404 RID: 70660
		[Token(Token = "0x4011404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Queue<float> bZlKZD[;

		// Token: 0x04011405 RID: 70661
		[Token(Token = "0x4011405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public float ACount;

		// Token: 0x04011406 RID: 70662
		[Token(Token = "0x4011406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private bool rSgGTOj;

		// Token: 0x04011407 RID: 70663
		[Token(Token = "0x4011407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		private bool }y[Xmpc;

		// Token: 0x04011408 RID: 70664
		[Token(Token = "0x4011408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		private bool OxMqIFY;

		// Token: 0x04011409 RID: 70665
		[Token(Token = "0x4011409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		private bool [W~\u0080bcj;

		// Token: 0x0401140A RID: 70666
		[Token(Token = "0x401140A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private float kTmFfz~;

		// Token: 0x0401140B RID: 70667
		[Token(Token = "0x401140B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		protected AvatarEffect c\u0081DzC\u0080L;

		// Token: 0x0401140C RID: 70668
		[Token(Token = "0x401140C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		protected GameObject O|i\u0080vD[;

		// Token: 0x0401140D RID: 70669
		[Token(Token = "0x401140D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected PropAnimComponent aCr|UdH;

		// Token: 0x0401140E RID: 70670
		[Token(Token = "0x401140E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected GameObject M\u0081YwgiS;

		// Token: 0x0401140F RID: 70671
		[Token(Token = "0x401140F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		protected BattleFlagConfigData hD}Dlcv;

		// Token: 0x04011410 RID: 70672
		[Token(Token = "0x4011410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		protected IEnumerator T}wZ}JO;

		// Token: 0x04011411 RID: 70673
		[Token(Token = "0x4011411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		protected IEnumerator dh\u0081i]cA;

		// Token: 0x04011412 RID: 70674
		[Token(Token = "0x4011412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private uint WEuu~\u0081Q;

		// Token: 0x04011413 RID: 70675
		[Token(Token = "0x4011413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private uint BbTurlO;

		// Token: 0x04011414 RID: 70676
		[Token(Token = "0x4011414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public ytMNhlw ActiveUISightingWeapon;

		// Token: 0x04011415 RID: 70677
		[Token(Token = "0x4011415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		protected mMxsv\u0080C EB{TANg;

		// Token: 0x04011416 RID: 70678
		[Token(Token = "0x4011416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public bool NextFireActionFromAuxButton;

		// Token: 0x04011417 RID: 70679
		[Token(Token = "0x4011417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		protected Quaternion bvdfbXj;

		// Token: 0x04011418 RID: 70680
		[Token(Token = "0x4011418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		protected Quaternion FJ\u0080\u0082TON;

		// Token: 0x04011419 RID: 70681
		[Token(Token = "0x4011419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public Gp m_AimAssist;

		// Token: 0x0401141A RID: 70682
		[Token(Token = "0x401141A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float ATsf[wI;

		// Token: 0x0401141B RID: 70683
		[Token(Token = "0x401141B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		private bool rLEnh\u0081R;

		// Token: 0x0401141C RID: 70684
		[Token(Token = "0x401141C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x255")]
		private bool iyBosou;

		// Token: 0x0401141D RID: 70685
		[Token(Token = "0x401141D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x256")]
		private bool bBhakxF;

		// Token: 0x0401141E RID: 70686
		[Token(Token = "0x401141E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x257")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11315C4", Offset = "0x11315C4")]
		private bool <arNHuYu>k__BackingField;

		// Token: 0x0401141F RID: 70687
		[Token(Token = "0x401141F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private EAimAssist Wtr}b\u0082y;

		// Token: 0x04011420 RID: 70688
		[Token(Token = "0x4011420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private V u\u0081knaMY;

		// Token: 0x04011421 RID: 70689
		[Token(Token = "0x4011421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		protected CbeeJ VNi\u0081slQ;

		// Token: 0x04011422 RID: 70690
		[Token(Token = "0x4011422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private FollowCamera uT~xORv;

		// Token: 0x04011423 RID: 70691
		[Token(Token = "0x4011423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		protected Transform yFayxSS;

		// Token: 0x04011424 RID: 70692
		[Token(Token = "0x4011424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		protected Transform JoqBDUR;

		// Token: 0x04011425 RID: 70693
		[Token(Token = "0x4011425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		protected Transform gBb{jci;

		// Token: 0x04011426 RID: 70694
		[Token(Token = "0x4011426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		protected Transform S~D]ly\u007F;

		// Token: 0x04011427 RID: 70695
		[Token(Token = "0x4011427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		protected Transform lJgBpso;

		// Token: 0x04011428 RID: 70696
		[Token(Token = "0x4011428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		protected Transform |[t\u0080t{c;

		// Token: 0x04011429 RID: 70697
		[Token(Token = "0x4011429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		protected Transform \u0082;

		// Token: 0x0401142A RID: 70698
		[Token(Token = "0x401142A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		protected Transform SrnCMrP;

		// Token: 0x0401142B RID: 70699
		[Token(Token = "0x401142B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		protected Transform jz\u0081gDN^;

		// Token: 0x0401142C RID: 70700
		[Token(Token = "0x401142C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		protected Transform APPZcef;

		// Token: 0x0401142D RID: 70701
		[Token(Token = "0x401142D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		protected Transform oporBaB;

		// Token: 0x0401142E RID: 70702
		[Token(Token = "0x401142E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		protected Transform lpF[hWQ;

		// Token: 0x0401142F RID: 70703
		[Token(Token = "0x401142F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		protected Transform yvZ[NRv;

		// Token: 0x04011430 RID: 70704
		[Token(Token = "0x4011430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		protected Transform iuhFwSC;

		// Token: 0x04011431 RID: 70705
		[Token(Token = "0x4011431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		protected Transform IcoOW\u0080F;

		// Token: 0x04011432 RID: 70706
		[Token(Token = "0x4011432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		protected Collider HSVblqt;

		// Token: 0x04011433 RID: 70707
		[Token(Token = "0x4011433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		protected \u0080uwjcYk e~Q\u007FmVq;

		// Token: 0x04011434 RID: 70708
		[Token(Token = "0x4011434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		protected NewPlayerAnimationSystemComponent X[iojBZ;

		// Token: 0x04011435 RID: 70709
		[Token(Token = "0x4011435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		protected PlayerAttributes lrVxE|d;

		// Token: 0x04011436 RID: 70710
		[Token(Token = "0x4011436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		protected AvatarManager hyh]D|l;

		// Token: 0x04011437 RID: 70711
		[Token(Token = "0x4011437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		protected AvatarDynamicEffectManager kCae~]X;

		// Token: 0x04011438 RID: 70712
		[Token(Token = "0x4011438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		protected AvatarPropManager kxfJKxi;

		// Token: 0x04011439 RID: 70713
		[Token(Token = "0x4011439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		protected PropertyData qsFN^H^;

		// Token: 0x0401143A RID: 70714
		[Token(Token = "0x401143A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		protected BigHeadComponent ]DjXMZe;

		// Token: 0x0401143B RID: 70715
		[Token(Token = "0x401143B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		protected BigHeadDataConfig Tz^^Uzo;

		// Token: 0x0401143C RID: 70716
		[Token(Token = "0x401143C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		protected float Nf\u0082nkzy;

		// Token: 0x0401143D RID: 70717
		[Token(Token = "0x401143D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		protected bool B^luSxb;

		// Token: 0x0401143E RID: 70718
		[Token(Token = "0x401143E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		protected GameObject YPXN;

		// Token: 0x0401143F RID: 70719
		[Token(Token = "0x401143F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11315D4", Offset = "0x11315D4")]
		private bool <}I|Hl}{>k__BackingField;

		// Token: 0x04011440 RID: 70720
		[Token(Token = "0x4011440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x351")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11315E4", Offset = "0x11315E4")]
		private bool <vc\u0080ouAb>k__BackingField;

		// Token: 0x04011441 RID: 70721
		[Token(Token = "0x4011441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		protected NavMeshAgent }fNP|hh;

		// Token: 0x04011442 RID: 70722
		[Token(Token = "0x4011442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11315F4", Offset = "0x11315F4")]
		private NetworkPet <mkRA]jS>k__BackingField;

		// Token: 0x04011443 RID: 70723
		[Token(Token = "0x4011443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private bool RSiTFcO;

		// Token: 0x04011444 RID: 70724
		[Token(Token = "0x4011444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		private float xl|]rE^;

		// Token: 0x04011445 RID: 70725
		[Token(Token = "0x4011445")]
		private const float ZASnygU = 0.5f;

		// Token: 0x04011446 RID: 70726
		[Token(Token = "0x4011446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private float ^vHUf~z;

		// Token: 0x04011447 RID: 70727
		[Token(Token = "0x4011447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		protected bool ]jl|q\u0082F;

		// Token: 0x04011448 RID: 70728
		[Token(Token = "0x4011448")]
		protected const int YShPrMD = 3;

		// Token: 0x04011449 RID: 70729
		[Token(Token = "0x4011449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		public uint CallSetAimRotationCount;

		// Token: 0x0401144A RID: 70730
		[Token(Token = "0x401144A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public string TeamColorStr;

		// Token: 0x0401144B RID: 70731
		[Token(Token = "0x401144B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		protected Ew ZylgkFq;

		// Token: 0x0401144C RID: 70732
		[Token(Token = "0x401144C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		protected TBTAction hv~awwX;

		// Token: 0x0401144D RID: 70733
		[Token(Token = "0x401144D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		protected {l\u0080cfSP mOoQWcT;

		// Token: 0x0401144E RID: 70734
		[Token(Token = "0x401144E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		protected TBTAction Od\u0082MUYC;

		// Token: 0x0401144F RID: 70735
		[Token(Token = "0x401144F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131604", Offset = "0x1131604")]
		private bool <~wcdLm[>k__BackingField;

		// Token: 0x04011450 RID: 70736
		[Token(Token = "0x4011450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3AC")]
		protected aZ rz\u0080B~hS;

		// Token: 0x04011451 RID: 70737
		[Token(Token = "0x4011451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		protected uint buSdyO\u0082;

		// Token: 0x04011452 RID: 70738
		[Token(Token = "0x4011452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B4")]
		protected byte GGy[MAa;

		// Token: 0x04011453 RID: 70739
		[Token(Token = "0x4011453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		protected List<Player.RbWp]Ul> fpkNrvd;

		// Token: 0x04011454 RID: 70740
		[Token(Token = "0x4011454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		protected int OYffzPn;

		// Token: 0x04011455 RID: 70741
		[Token(Token = "0x4011455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		protected Vector3 \u0080ryWGel;

		// Token: 0x04011456 RID: 70742
		[Token(Token = "0x4011456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		protected Vector3 U|jhgMU;

		// Token: 0x04011457 RID: 70743
		[Token(Token = "0x4011457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
		protected bool OHI\u007FCQI;

		// Token: 0x04011458 RID: 70744
		[Token(Token = "0x4011458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3DD")]
		protected bool u\u0081DBKT\u0081;

		// Token: 0x04011459 RID: 70745
		[Token(Token = "0x4011459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private List<int> U[XNxe};

		// Token: 0x0401145A RID: 70746
		[Token(Token = "0x401145A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private List<int> T[rgGZM;

		// Token: 0x0401145B RID: 70747
		[Token(Token = "0x401145B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private List<int> <<EMPTY_NAME>>;

		// Token: 0x0401145C RID: 70748
		[Token(Token = "0x401145C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		public float DamageZoneSpeedScale;

		// Token: 0x0401145D RID: 70749
		[Token(Token = "0x401145D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private Dictionary<uint, float> oXE|Ai\u0080;

		// Token: 0x0401145E RID: 70750
		[Token(Token = "0x401145E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private List<ClimbingTrigger> \u0081\u0081aca^};

		// Token: 0x0401145F RID: 70751
		[Token(Token = "0x401145F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private ClimbingTrigger V|kZ~\u0082X;

		// Token: 0x04011460 RID: 70752
		[Token(Token = "0x4011460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private List<Collider> PMakSKS;

		// Token: 0x04011461 RID: 70753
		[Token(Token = "0x4011461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		public LevelDoor CurProcessLevelDoor;

		// Token: 0x04011462 RID: 70754
		[Token(Token = "0x4011462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		protected Vector3 XjUgcFr;

		// Token: 0x04011463 RID: 70755
		[Token(Token = "0x4011463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		protected Vehicle lTKGh}y;

		// Token: 0x04011464 RID: 70756
		[Token(Token = "0x4011464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		protected LevelStrop mZQ\u007F^vN;

		// Token: 0x04011465 RID: 70757
		[Token(Token = "0x4011465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		protected FerrisWheelSeatGroup gte~oF^;

		// Token: 0x04011466 RID: 70758
		[Token(Token = "0x4011466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		protected float dHj\u0081SEm;

		// Token: 0x04011467 RID: 70759
		[Token(Token = "0x4011467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		protected LevelChair MsR~RtX;

		// Token: 0x04011468 RID: 70760
		[Token(Token = "0x4011468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		protected LevelCatapult TEWnUPa;

		// Token: 0x04011469 RID: 70761
		[Token(Token = "0x4011469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		protected Quaternion S[Vp|s\u0082;

		// Token: 0x0401146A RID: 70762
		[Token(Token = "0x401146A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		protected LevelFerrisWheel \u0081xjXe[O;

		// Token: 0x0401146B RID: 70763
		[Token(Token = "0x401146B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		protected Transform v[\u0080H;

		// Token: 0x0401146C RID: 70764
		[Token(Token = "0x401146C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		protected Transform XFWZ~v\u0082;

		// Token: 0x0401146D RID: 70765
		[Token(Token = "0x401146D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		protected Transform ThUjciY;

		// Token: 0x0401146E RID: 70766
		[Token(Token = "0x401146E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		protected Transform Cf]c[|w;

		// Token: 0x0401146F RID: 70767
		[Token(Token = "0x401146F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private float qCkPZk[;

		// Token: 0x04011470 RID: 70768
		[Token(Token = "0x4011470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
		private float rJANuS\u0081;

		// Token: 0x04011471 RID: 70769
		[Token(Token = "0x4011471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		protected Vector3 ITtsXUF;

		// Token: 0x04011472 RID: 70770
		[Token(Token = "0x4011472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		protected LevelGrapplingHook IFT\u0082Tkp;

		// Token: 0x04011473 RID: 70771
		[Token(Token = "0x4011473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		protected bool TZrtCW{;

		// Token: 0x04011474 RID: 70772
		[Token(Token = "0x4011474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131614", Offset = "0x1131614")]
		private bool <]\u007FTO\u0082Zz>k__BackingField;

		// Token: 0x04011475 RID: 70773
		[Token(Token = "0x4011475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131624", Offset = "0x1131624")]
		private int <bLrpfIA>k__BackingField;

		// Token: 0x04011476 RID: 70774
		[Token(Token = "0x4011476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private uint ]}ay|[I;

		// Token: 0x04011477 RID: 70775
		[Token(Token = "0x4011477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131634", Offset = "0x1131634")]
		private bool <NX\u0080BxLu>k__BackingField;

		// Token: 0x04011478 RID: 70776
		[Token(Token = "0x4011478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4CD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131644", Offset = "0x1131644")]
		private bool <\u007FYWUzst>k__BackingField;

		// Token: 0x04011479 RID: 70777
		[Token(Token = "0x4011479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4CE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131654", Offset = "0x1131654")]
		private bool <Lcx{YkO>k__BackingField;

		// Token: 0x0401147A RID: 70778
		[Token(Token = "0x401147A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4CF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131664", Offset = "0x1131664")]
		private bool <;

		// Token: 0x0401147B RID: 70779
		[Token(Token = "0x401147B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private bool bRmmXa\u0081;

		// Token: 0x0401147C RID: 70780
		[Token(Token = "0x401147C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D1")]
		private bool wPIPrT~;

		// Token: 0x0401147D RID: 70781
		[Token(Token = "0x401147D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131674", Offset = "0x1131674")]
		private bool <r\u0080\u007FL\u0082ZK>k__BackingField;

		// Token: 0x0401147E RID: 70782
		[Token(Token = "0x401147E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D3")]
		private bool uSF\u0082w^b;

		// Token: 0x0401147F RID: 70783
		[Token(Token = "0x401147F")]
		protected const uint }geDKbG = 1U;

		// Token: 0x04011480 RID: 70784
		[Token(Token = "0x4011480")]
		protected const uint wkuaFER = 2U;

		// Token: 0x04011481 RID: 70785
		[Token(Token = "0x4011481")]
		protected const uint zC]vUAM = 4U;

		// Token: 0x04011482 RID: 70786
		[Token(Token = "0x4011482")]
		protected const uint ICTOMov = 8U;

		// Token: 0x04011483 RID: 70787
		[Token(Token = "0x4011483")]
		protected const uint nO{C\u007Ff\u0082 = 16U;

		// Token: 0x04011484 RID: 70788
		[Token(Token = "0x4011484")]
		protected const uint DSoYsvW = 32U;

		// Token: 0x04011485 RID: 70789
		[Token(Token = "0x4011485")]
		protected const uint lrfAtN\u007F = 64U;

		// Token: 0x04011486 RID: 70790
		[Token(Token = "0x4011486")]
		protected const uint PB\u0082}K|h = 128U;

		// Token: 0x04011487 RID: 70791
		[Token(Token = "0x4011487")]
		protected const uint ^BLqymB = 256U;

		// Token: 0x04011488 RID: 70792
		[Token(Token = "0x4011488")]
		protected const uint \u007FFRx[At = 512U;

		// Token: 0x04011489 RID: 70793
		[Token(Token = "0x4011489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		protected BitArrayBoolean NP^Vi\u0082};

		// Token: 0x0401148A RID: 70794
		[Token(Token = "0x401148A")]
		protected const uint on\u0082EF = 1U;

		// Token: 0x0401148B RID: 70795
		[Token(Token = "0x401148B")]
		protected const uint ]Ztj{{y = 2U;

		// Token: 0x0401148C RID: 70796
		[Token(Token = "0x401148C")]
		protected const uint gSKa = 4U;

		// Token: 0x0401148D RID: 70797
		[Token(Token = "0x401148D")]
		public const uint ISVISIBLE_ONBOARD = 8U;

		// Token: 0x0401148E RID: 70798
		[Token(Token = "0x401148E")]
		public const uint ISVISIBLE_SKILL = 16U;

		// Token: 0x0401148F RID: 70799
		[Token(Token = "0x401148F")]
		public const uint ISVISIBLE_ALIVE = 32U;

		// Token: 0x04011490 RID: 70800
		[Token(Token = "0x4011490")]
		public const uint ISVISIBLE_INCUTSCENE = 64U;

		// Token: 0x04011491 RID: 70801
		[Token(Token = "0x4011491")]
		public const uint ISVISIBLE_PRI = 128U;

		// Token: 0x04011492 RID: 70802
		[Token(Token = "0x4011492")]
		public const uint ISVISIBLE_Transform = 256U;

		// Token: 0x04011493 RID: 70803
		[Token(Token = "0x4011493")]
		public const uint ISVISIBLE_ZoneChange = 512U;

		// Token: 0x04011494 RID: 70804
		[Token(Token = "0x4011494")]
		public const uint ISVISIBLE_Animation = 1024U;

		// Token: 0x04011495 RID: 70805
		[Token(Token = "0x4011495")]
		public const uint ISVISIBLE_WereWolfDead = 2048U;

		// Token: 0x04011496 RID: 70806
		[Token(Token = "0x4011496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		protected BitArrayBoolean FGLbWi\u007F;

		// Token: 0x04011497 RID: 70807
		[Token(Token = "0x4011497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		protected bool i\u0081eLspx;

		// Token: 0x04011498 RID: 70808
		[Token(Token = "0x4011498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		protected Transform DTg{YmU;

		// Token: 0x04011499 RID: 70809
		[Token(Token = "0x4011499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		protected List<ZjcDgQ\u007F> v\u0080\u0082AoHP;

		// Token: 0x0401149A RID: 70810
		[Token(Token = "0x401149A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		public bool IsSkillActive;

		// Token: 0x0401149B RID: 70811
		[Token(Token = "0x401149B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		protected r^RKaYZ RJWAT\u0082P;

		// Token: 0x0401149C RID: 70812
		[Token(Token = "0x401149C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private bool dZ\u007FtzmR;

		// Token: 0x0401149D RID: 70813
		[Token(Token = "0x401149D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private Texture2D PseQ]P\u007F;

		// Token: 0x0401149E RID: 70814
		[Token(Token = "0x401149E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private float \u0080S|\u0081bT\u0080;

		// Token: 0x0401149F RID: 70815
		[Token(Token = "0x401149F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x524")]
		private float xuBp]VN;

		// Token: 0x040114A0 RID: 70816
		[Token(Token = "0x40114A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private float n;

		// Token: 0x040114A1 RID: 70817
		[Token(Token = "0x40114A1")]
		private const float PusmabI = 0.02f;

		// Token: 0x040114A2 RID: 70818
		[Token(Token = "0x40114A2")]
		private const float \u0080OQkYuV = 0.5f;

		// Token: 0x040114A3 RID: 70819
		[Token(Token = "0x40114A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private MDsfkBx dsqunEm;

		// Token: 0x040114A4 RID: 70820
		[Token(Token = "0x40114A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private GGfm}Dt ZecVuTc;

		// Token: 0x040114A5 RID: 70821
		[Token(Token = "0x40114A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private MDsfkBx Hvgw^UB;

		// Token: 0x040114A6 RID: 70822
		[Token(Token = "0x40114A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		private CapsuleHuman }UR\u007F\u0081Xv;

		// Token: 0x040114A7 RID: 70823
		[Token(Token = "0x40114A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		private CapsuleCollider \u0082h{\u007FnNh;

		// Token: 0x040114A8 RID: 70824
		[Token(Token = "0x40114A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private readonly float DJHrr[S;

		// Token: 0x040114A9 RID: 70825
		[Token(Token = "0x40114A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55C")]
		private readonly Vector3 XZSiLA[;

		// Token: 0x040114AA RID: 70826
		[Token(Token = "0x40114AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private bool cjIB|zG;

		// Token: 0x040114AB RID: 70827
		[Token(Token = "0x40114AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private GameObject J{EfXbo;

		// Token: 0x040114AC RID: 70828
		[Token(Token = "0x40114AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private List<CapsuleCollider> AfOLsxk;

		// Token: 0x040114AD RID: 70829
		[Token(Token = "0x40114AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private AudioResource ~Pi\u0082p;

		// Token: 0x040114AE RID: 70830
		[Token(Token = "0x40114AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private AudioResource wmbdI\u0081L;

		// Token: 0x040114AF RID: 70831
		[Token(Token = "0x40114AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		protected bool j^LsnDw;

		// Token: 0x040114B0 RID: 70832
		[Token(Token = "0x40114B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x594")]
		protected int h\u007FRn~}};

		// Token: 0x040114B1 RID: 70833
		[Token(Token = "0x40114B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private LevelTriggerFountain.SO~^\u0080SV ZETt[xq;

		// Token: 0x040114B2 RID: 70834
		[Token(Token = "0x40114B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private List<LevelTriggerHumanTire> TXZdQM\u007F;

		// Token: 0x040114B3 RID: 70835
		[Token(Token = "0x40114B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private Player.WJA\u0080Xxv hxVG\u0082ZR;

		// Token: 0x040114B4 RID: 70836
		[Token(Token = "0x40114B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131684", Offset = "0x1131684")]
		private uint <clAreNL>k__BackingField;

		// Token: 0x040114B5 RID: 70837
		[Token(Token = "0x40114B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private float SRExTQh;

		// Token: 0x040114B6 RID: 70838
		[Token(Token = "0x40114B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B4")]
		private float UlJLM\u0082i;

		// Token: 0x040114B7 RID: 70839
		[Token(Token = "0x40114B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private bool yfGDmFy;

		// Token: 0x040114B8 RID: 70840
		[Token(Token = "0x40114B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B9")]
		private bool O{}B\u007F\u0080K;

		// Token: 0x040114B9 RID: 70841
		[Token(Token = "0x40114B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5BA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131694", Offset = "0x1131694")]
		private bool <uOEXpJb>k__BackingField;

		// Token: 0x040114BA RID: 70842
		[Token(Token = "0x40114BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5BC")]
		protected ResourceID Nmop\u0082y;

		// Token: 0x040114BB RID: 70843
		[Token(Token = "0x40114BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		protected ResourceID r[Y~YVU;

		// Token: 0x040114BC RID: 70844
		[Token(Token = "0x40114BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C4")]
		protected ResourceID t]ol\u0081iY;

		// Token: 0x040114BD RID: 70845
		[Token(Token = "0x40114BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		protected SkyboardData zdXd\u0082zu;

		// Token: 0x040114BE RID: 70846
		[Token(Token = "0x40114BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		protected PlayerAudioComponent CIBPETU;

		// Token: 0x040114BF RID: 70847
		[Token(Token = "0x40114BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		protected GameObject MiWVBYA;

		// Token: 0x040114C0 RID: 70848
		[Token(Token = "0x40114C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		protected Flight YHzrC}t;

		// Token: 0x040114C1 RID: 70849
		[Token(Token = "0x40114C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		protected Animator i\u0081KLYjv;

		// Token: 0x040114C2 RID: 70850
		[Token(Token = "0x40114C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		protected GameObject qXIcTve;

		// Token: 0x040114C3 RID: 70851
		[Token(Token = "0x40114C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		protected Parachute MuOk]Zu;

		// Token: 0x040114C4 RID: 70852
		[Token(Token = "0x40114C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		protected GameObject KmqJXKx;

		// Token: 0x040114C5 RID: 70853
		[Token(Token = "0x40114C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		protected GameObject ~UBwULl;

		// Token: 0x040114C6 RID: 70854
		[Token(Token = "0x40114C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		protected GameObject qusQgDq;

		// Token: 0x040114C7 RID: 70855
		[Token(Token = "0x40114C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		protected GameObject JRgysuv;

		// Token: 0x040114C8 RID: 70856
		[Token(Token = "0x40114C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		protected GameObject ~vMenO\u0080;

		// Token: 0x040114C9 RID: 70857
		[Token(Token = "0x40114C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		protected GameObject QqJg[hG;

		// Token: 0x040114CA RID: 70858
		[Token(Token = "0x40114CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		protected GameObject lBMsgxj;

		// Token: 0x040114CB RID: 70859
		[Token(Token = "0x40114CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		protected GameObject r]yJnVU;

		// Token: 0x040114CC RID: 70860
		[Token(Token = "0x40114CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		protected StropRing [PedyqQ;

		// Token: 0x040114CD RID: 70861
		[Token(Token = "0x40114CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
		protected GameObject {\u007FuyvZe;

		// Token: 0x040114CE RID: 70862
		[Token(Token = "0x40114CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		protected GameObject E[PznY];

		// Token: 0x040114CF RID: 70863
		[Token(Token = "0x40114CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x658")]
		public GameObject m_CamouflageUniformGO;

		// Token: 0x040114D0 RID: 70864
		[Token(Token = "0x40114D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		protected GameObject ^O]GbRu;

		// Token: 0x040114D1 RID: 70865
		[Token(Token = "0x40114D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		protected GameObject zxRsEFr;

		// Token: 0x040114D2 RID: 70866
		[Token(Token = "0x40114D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		protected Dictionary<ResourceID, List<GameObject>> VjH~W~f;

		// Token: 0x040114D3 RID: 70867
		[Token(Token = "0x40114D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		private GameObject VPSK;

		// Token: 0x040114D4 RID: 70868
		[Token(Token = "0x40114D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		protected GameObject GSsQfDx;

		// Token: 0x040114D5 RID: 70869
		[Token(Token = "0x40114D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		protected ResourceID AMaC}tO;

		// Token: 0x040114D6 RID: 70870
		[Token(Token = "0x40114D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		protected GameObject natfaWx;

		// Token: 0x040114D7 RID: 70871
		[Token(Token = "0x40114D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		protected ResourceID {yZNkf\u0082;

		// Token: 0x040114D8 RID: 70872
		[Token(Token = "0x40114D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69C")]
		protected ResourceID R\u007FwJzXR;

		// Token: 0x040114D9 RID: 70873
		[Token(Token = "0x40114D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		private Dictionary<int, ResourceID> XKzrB\u0082~;

		// Token: 0x040114DA RID: 70874
		[Token(Token = "0x40114DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		private GameObject pC|sF^;

		// Token: 0x040114DB RID: 70875
		[Token(Token = "0x40114DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		private bool VE;

		// Token: 0x040114DC RID: 70876
		[Token(Token = "0x40114DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B4")]
		private float t\u0080[GZ\u0082E;

		// Token: 0x040114DD RID: 70877
		[Token(Token = "0x40114DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		private ZykjDpa oB{o}Hp;

		// Token: 0x040114DE RID: 70878
		[Token(Token = "0x40114DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BC")]
		private bool |aTAQEn;

		// Token: 0x040114DF RID: 70879
		[Token(Token = "0x40114DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		private Quaternion pTrSBsB;

		// Token: 0x040114E0 RID: 70880
		[Token(Token = "0x40114E0")]
		private const float q~TNgAm = 35f;

		// Token: 0x040114E1 RID: 70881
		[Token(Token = "0x40114E1")]
		private const float zivUQCB = 135f;

		// Token: 0x040114E2 RID: 70882
		[Token(Token = "0x40114E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		private float [qWVk|C;

		// Token: 0x040114E3 RID: 70883
		[Token(Token = "0x40114E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D4")]
		public float m_ControlDirectionResetTime;

		// Token: 0x040114E4 RID: 70884
		[Token(Token = "0x40114E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		public float m_AuxAimResetTime;

		// Token: 0x040114E5 RID: 70885
		[Token(Token = "0x40114E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DC")]
		public float m_MinAngleX;

		// Token: 0x040114E6 RID: 70886
		[Token(Token = "0x40114E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		public float m_MaxAngleX;

		// Token: 0x040114E7 RID: 70887
		[Token(Token = "0x40114E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E4")]
		private float R{F\u007Fan^;

		// Token: 0x040114E8 RID: 70888
		[Token(Token = "0x40114E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		private MDsfkBx GWWUfW];

		// Token: 0x040114E9 RID: 70889
		[Token(Token = "0x40114E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		private MDsfkBx {WRFrvK;

		// Token: 0x040114EA RID: 70890
		[Token(Token = "0x40114EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		public bool LastAimingInfoFromWeaponAdjusted;

		// Token: 0x040114EB RID: 70891
		[Token(Token = "0x40114EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F9")]
		private bool eAdUpKK;

		// Token: 0x040114EC RID: 70892
		[Token(Token = "0x40114EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FA")]
		private bool hVu\u0082{qc;

		// Token: 0x040114ED RID: 70893
		[Token(Token = "0x40114ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11316A4", Offset = "0x11316A4")]
		private \u0081{oGdwC <I{lLQaL>k__BackingField;

		// Token: 0x040114EE RID: 70894
		[Token(Token = "0x40114EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
		private uint H\u0080\u0082ne|h;

		// Token: 0x040114EF RID: 70895
		[Token(Token = "0x40114EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70C")]
		public float LastPlayBulletTrackEffectTime;

		// Token: 0x040114F0 RID: 70896
		[Token(Token = "0x40114F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		private GameObject qk]MNKq;

		// Token: 0x040114F1 RID: 70897
		[Token(Token = "0x40114F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		private GameObject cTloNkr;

		// Token: 0x040114F2 RID: 70898
		[Token(Token = "0x40114F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		private GameObject rA{lsnM;

		// Token: 0x040114F3 RID: 70899
		[Token(Token = "0x40114F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x728")]
		private GameObject |HfEgrV;

		// Token: 0x040114F4 RID: 70900
		[Token(Token = "0x40114F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		private GameObject LdajSFj;

		// Token: 0x040114F5 RID: 70901
		[Token(Token = "0x40114F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x738")]
		private GameObject t|\u007FSx\u007FM;

		// Token: 0x040114F6 RID: 70902
		[Token(Token = "0x40114F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		private bool tOodvIM;

		// Token: 0x040114F7 RID: 70903
		[Token(Token = "0x40114F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		private GameObject bO\u0081X|GF;

		// Token: 0x040114F8 RID: 70904
		[Token(Token = "0x40114F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		private ResourceID GAFeLar;

		// Token: 0x040114F9 RID: 70905
		[Token(Token = "0x40114F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		private GameObject RC\u007FrPYX;

		// Token: 0x040114FA RID: 70906
		[Token(Token = "0x40114FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		private ResourceID ^FMb}hu;

		// Token: 0x040114FB RID: 70907
		[Token(Token = "0x40114FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		private GameObject wvjV~vp;

		// Token: 0x040114FC RID: 70908
		[Token(Token = "0x40114FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		private ResourceID [j^Jjdh;

		// Token: 0x040114FD RID: 70909
		[Token(Token = "0x40114FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		private GameObject GXE{vUC;

		// Token: 0x040114FE RID: 70910
		[Token(Token = "0x40114FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		protected AudioResource {TwZW}\u0082;

		// Token: 0x040114FF RID: 70911
		[Token(Token = "0x40114FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		private float BFV;

		// Token: 0x04011500 RID: 70912
		[Token(Token = "0x4011500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78C")]
		private bool eeuIVjj;

		// Token: 0x04011501 RID: 70913
		[Token(Token = "0x4011501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		private float yZdJW[e;

		// Token: 0x04011502 RID: 70914
		[Token(Token = "0x4011502")]
		private const float KpORAwy = 326f;

		// Token: 0x04011503 RID: 70915
		[Token(Token = "0x4011503")]
		private const float KLTcwpI = 300f;

		// Token: 0x04011504 RID: 70916
		[Token(Token = "0x4011504")]
		private const float \u0082kAP\u0082b^ = 3f;

		// Token: 0x04011505 RID: 70917
		[Token(Token = "0x4011505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		protected LevelItemPlant yoXvNhJ;

		// Token: 0x04011506 RID: 70918
		[Token(Token = "0x4011506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		private LinkedList<Vector2> F\u0082\u0080cqMT;

		// Token: 0x04011507 RID: 70919
		[Token(Token = "0x4011507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11316B4", Offset = "0x11316B4")]
		private bool <Ud\u007F{EWh>k__BackingField;

		// Token: 0x04011508 RID: 70920
		[Token(Token = "0x4011508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		private List<Vector3> K\u0082WvBun;

		// Token: 0x04011509 RID: 70921
		[Token(Token = "0x4011509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
		protected List<GameObject> WDmYwyn;

		// Token: 0x0401150A RID: 70922
		[Token(Token = "0x401150A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
		private int dHrjM^B;

		// Token: 0x0401150B RID: 70923
		[Token(Token = "0x401150B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C4")]
		private bool \u0082DoIbR];

		// Token: 0x0401150C RID: 70924
		[Token(Token = "0x401150C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
		private float eWNvFOt;

		// Token: 0x0401150D RID: 70925
		[Token(Token = "0x401150D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		protected Player.yyEoKfi Xg\u0082Txyd;

		// Token: 0x0401150E RID: 70926
		[Token(Token = "0x401150E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		private bool CM;

		// Token: 0x0401150F RID: 70927
		[Token(Token = "0x401150F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7DC")]
		private float DH}T]{q;

		// Token: 0x04011510 RID: 70928
		[Token(Token = "0x4011510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		private Vector2 LnRzD;

		// Token: 0x04011511 RID: 70929
		[Token(Token = "0x4011511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		private AudioResource hDsXSed;

		// Token: 0x04011512 RID: 70930
		[Token(Token = "0x4011512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		private bool {sqxHi];

		// Token: 0x04011513 RID: 70931
		[Token(Token = "0x4011513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F1")]
		private bool Nqn]zVo;

		// Token: 0x04011514 RID: 70932
		[Token(Token = "0x4011514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		private List<GameObject> bUaZ]Qg;

		// Token: 0x04011515 RID: 70933
		[Token(Token = "0x4011515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		private PCAirTrailView eGY~Ucv;

		// Token: 0x04011516 RID: 70934
		[Token(Token = "0x4011516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x808")]
		private LevelEmote NJCguP\u0082;

		// Token: 0x04011517 RID: 70935
		[Token(Token = "0x4011517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		private ResourceID kmuQix;

		// Token: 0x04011518 RID: 70936
		[Token(Token = "0x4011518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x818")]
		private GameObject |XBYNT[;

		// Token: 0x04011519 RID: 70937
		[Token(Token = "0x4011519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		private Dictionary<GameObject, Transform> WYvR`J;

		// Token: 0x0401151A RID: 70938
		[Token(Token = "0x401151A")]
		private const uint GW\u0081[a\u0080W = 2U;

		// Token: 0x0401151B RID: 70939
		[Token(Token = "0x401151B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x828")]
		public Player.X|\u0082sRVj ActSkillUpdateKinmaticsCall;

		// Token: 0x0401151C RID: 70940
		[Token(Token = "0x401151C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x830")]
		protected xM\u0080cEzB pLjWoMK;

		// Token: 0x0401151D RID: 70941
		[Token(Token = "0x401151D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x838")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11316C4", Offset = "0x11316C4")]
		private bool <jgSob~u>k__BackingField;

		// Token: 0x0401151E RID: 70942
		[Token(Token = "0x401151E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x839")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11316D4", Offset = "0x11316D4")]
		private bool <pOfWBHb>k__BackingField;

		// Token: 0x0401151F RID: 70943
		[Token(Token = "0x401151F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11316E4", Offset = "0x11316E4")]
		private bool <^UbPn;

		// Token: 0x04011520 RID: 70944
		[Token(Token = "0x4011520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11316F4", Offset = "0x11316F4")]
		private bool <\u0082Vm\u0082MuA>k__BackingField;

		// Token: 0x04011521 RID: 70945
		[Token(Token = "0x4011521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131704", Offset = "0x1131704")]
		private bool <Ov;

		// Token: 0x04011522 RID: 70946
		[Token(Token = "0x4011522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83D")]
		public bool IsKnockedDownBleed;

		// Token: 0x04011523 RID: 70947
		[Token(Token = "0x4011523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x840")]
		private Transform {UTBBri;

		// Token: 0x04011524 RID: 70948
		[Token(Token = "0x4011524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x848")]
		public GameObject m_TransformObject;

		// Token: 0x04011525 RID: 70949
		[Token(Token = "0x4011525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x850")]
		private b]LTXBp z^HiDzB;

		// Token: 0x04011526 RID: 70950
		[Token(Token = "0x4011526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x858")]
		protected bool \u0081M{u^kK;

		// Token: 0x04011527 RID: 70951
		[Token(Token = "0x4011527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x860")]
		protected GameObject \u0080zI;

		// Token: 0x04011528 RID: 70952
		[Token(Token = "0x4011528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x868")]
		private Dictionary<uint, float> \u0080;

		// Token: 0x04011529 RID: 70953
		[Token(Token = "0x4011529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x870")]
		protected CkM\u0081f\u0081q ndNbULv;

		// Token: 0x0401152A RID: 70954
		[Token(Token = "0x401152A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x878")]
		private float An|N[IQ;

		// Token: 0x0401152B RID: 70955
		[Token(Token = "0x401152B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87C")]
		private float }}g\u0081ZqT;

		// Token: 0x0401152C RID: 70956
		[Token(Token = "0x401152C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		private float iU\u0081Sawq;

		// Token: 0x0401152D RID: 70957
		[Token(Token = "0x401152D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x884")]
		private float qslx\u007FeM;

		// Token: 0x0401152E RID: 70958
		[Token(Token = "0x401152E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x888")]
		private Quaternion ~Fd]RhW;

		// Token: 0x0401152F RID: 70959
		[Token(Token = "0x401152F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x898")]
		private Quaternion xUFtCbn;

		// Token: 0x04011530 RID: 70960
		[Token(Token = "0x4011530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
		private Quaternion [J\u0082XnzW;

		// Token: 0x04011531 RID: 70961
		[Token(Token = "0x4011531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
		private Quaternion \u007FcjJF[p;

		// Token: 0x04011532 RID: 70962
		[Token(Token = "0x4011532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
		private ClimbingTrigger xlCVsKh;

		// Token: 0x04011533 RID: 70963
		[Token(Token = "0x4011533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D0")]
		public float minAngleInCreep;

		// Token: 0x04011534 RID: 70964
		[Token(Token = "0x4011534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D4")]
		public float maxAngleInCreep;

		// Token: 0x04011535 RID: 70965
		[Token(Token = "0x4011535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D8")]
		private MDsfkBx <<EMPTY_NAME>>;

		// Token: 0x04011536 RID: 70966
		[Token(Token = "0x4011536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E0")]
		private bool? DDl^pa\u0080;

		// Token: 0x04011537 RID: 70967
		[Token(Token = "0x4011537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E4")]
		private float utzwqSU;

		// Token: 0x04011538 RID: 70968
		[Token(Token = "0x4011538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E8")]
		private float rYU{QE{;

		// Token: 0x04011539 RID: 70969
		[Token(Token = "0x4011539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8EC")]
		public bool IsDoubleJumpTriggered;

		// Token: 0x0401153A RID: 70970
		[Token(Token = "0x401153A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F0")]
		protected GameObject }hFDnse;

		// Token: 0x0401153B RID: 70971
		[Token(Token = "0x401153B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F8")]
		protected GameObject Iib^XBL;

		// Token: 0x0401153C RID: 70972
		[Token(Token = "0x401153C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x900")]
		protected A\u0082[c^\u007FE hwUOJjr;

		// Token: 0x0401153D RID: 70973
		[Token(Token = "0x401153D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x908")]
		protected eGHwBLs ZtpAcNd;

		// Token: 0x0401153E RID: 70974
		[Token(Token = "0x401153E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x910")]
		private FoldWingConfigData e\u007FQddVX;

		// Token: 0x0401153F RID: 70975
		[Token(Token = "0x401153F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x918")]
		public GameObject m_FoldWingIAmIn;

		// Token: 0x04011540 RID: 70976
		[Token(Token = "0x4011540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x920")]
		private bool bP~{F^Y;

		// Token: 0x04011541 RID: 70977
		[Token(Token = "0x4011541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x924")]
		private uint xq\u0082aXq|;

		// Token: 0x04011542 RID: 70978
		[Token(Token = "0x4011542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x928")]
		protected float a}E\u0080v\u007Fd;

		// Token: 0x04011543 RID: 70979
		[Token(Token = "0x4011543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x930")]
		protected GameObject IyFUcIH;

		// Token: 0x04011544 RID: 70980
		[Token(Token = "0x4011544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x938")]
		protected SphereCollider I|jNCQ\u0081;

		// Token: 0x04011545 RID: 70981
		[Token(Token = "0x4011545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x940")]
		protected Football Doe}UCA;

		// Token: 0x04011546 RID: 70982
		[Token(Token = "0x4011546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x948")]
		protected float fgJoy[\u0082;

		// Token: 0x04011547 RID: 70983
		[Token(Token = "0x4011547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94C")]
		protected bool FB\u0081J;

		// Token: 0x04011548 RID: 70984
		[Token(Token = "0x4011548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float FOOTBALL_MOVE_EPSILON;

		// Token: 0x04011549 RID: 70985
		[Token(Token = "0x4011549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x950")]
		protected Vector3 bfpFYlJ;

		// Token: 0x0401154A RID: 70986
		[Token(Token = "0x401154A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x960")]
		protected GameObject pJ}\u0081HUY;

		// Token: 0x0401154B RID: 70987
		[Token(Token = "0x401154B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x968")]
		protected AudioSource eaoj[\u0082o;

		// Token: 0x0401154C RID: 70988
		[Token(Token = "0x401154C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x970")]
		private float ];

		// Token: 0x0401154D RID: 70989
		[Token(Token = "0x401154D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x974")]
		private Vector3 gPj[\u0080CT;

		// Token: 0x0401154E RID: 70990
		[Token(Token = "0x401154E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x980")]
		private ResourceID s]XgmMn;

		// Token: 0x0401154F RID: 70991
		[Token(Token = "0x401154F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x988")]
		protected eoFJwfC \u0080\u007FkWF\u007Fb;

		// Token: 0x04011550 RID: 70992
		[Token(Token = "0x4011550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x990")]
		protected GameObject lmipkb|;

		// Token: 0x04011551 RID: 70993
		[Token(Token = "0x4011551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x998")]
		private MDsfkBx qPqDyyy;

		// Token: 0x04011552 RID: 70994
		[Token(Token = "0x4011552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A0")]
		protected LevelMovePlatform \u007FmFzJuB;

		// Token: 0x04011553 RID: 70995
		[Token(Token = "0x4011553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A8")]
		protected Vector3 \u0082{[bnMk;

		// Token: 0x04011554 RID: 70996
		[Token(Token = "0x4011554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B4")]
		protected Vector3 \u0082oJISQb;

		// Token: 0x04011555 RID: 70997
		[Token(Token = "0x4011555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C0")]
		protected Player.}Tv]tpI YHifWQT;

		// Token: 0x04011556 RID: 70998
		[Token(Token = "0x4011556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C8")]
		private float OgBgdhz;

		// Token: 0x04011557 RID: 70999
		[Token(Token = "0x4011557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9CC")]
		private byte lJj\u0080]kE;

		// Token: 0x04011558 RID: 71000
		[Token(Token = "0x4011558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D0")]
		protected sc VsWiFE\u007F;

		// Token: 0x04011559 RID: 71001
		[Token(Token = "0x4011559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D4")]
		private uint SaBvb;

		// Token: 0x0401155A RID: 71002
		[Token(Token = "0x401155A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D8")]
		public float LastHitEffectTime;

		// Token: 0x0401155B RID: 71003
		[Token(Token = "0x401155B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9DC")]
		protected int \u0081SPsOdP;

		// Token: 0x0401155C RID: 71004
		[Token(Token = "0x401155C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E0")]
		private bool s]OLCop;

		// Token: 0x0401155D RID: 71005
		[Token(Token = "0x401155D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E8")]
		private List<uint> FUvKzhi;

		// Token: 0x0401155E RID: 71006
		[Token(Token = "0x401155E")]
		public const VCDxuoO SkateboardJumpPose = VCDxuoO.EPHYSXPOSE_LOWFALLING;

		// Token: 0x0401155F RID: 71007
		[Token(Token = "0x401155F")]
		public const VCDxuoO SkateboardSecondJumpPose = VCDxuoO.EPHYSXPOSE_SECONDFALLING;

		// Token: 0x04011560 RID: 71008
		[Token(Token = "0x4011560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F0")]
		private Player.yyEoKfi l}FMyC];

		// Token: 0x04011561 RID: 71009
		[Token(Token = "0x4011561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F8")]
		private Player.yyEoKfi \u007FCIWU{V;

		// Token: 0x04011562 RID: 71010
		[Token(Token = "0x4011562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA00")]
		private Player.yyEoKfi h^SoxOt;

		// Token: 0x04011563 RID: 71011
		[Token(Token = "0x4011563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA08")]
		private Player.yyEoKfi n\u0082dHUfg;

		// Token: 0x04011564 RID: 71012
		[Token(Token = "0x4011564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA10")]
		private ResourceID FFRmm]\u0080;

		// Token: 0x04011565 RID: 71013
		[Token(Token = "0x4011565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA18")]
		private GameObject CcTuOTl;

		// Token: 0x04011566 RID: 71014
		[Token(Token = "0x4011566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA20")]
		private GameObject R;

		// Token: 0x04011567 RID: 71015
		[Token(Token = "0x4011567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA28")]
		private bool Z[WGwQK;

		// Token: 0x04011568 RID: 71016
		[Token(Token = "0x4011568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2C")]
		private int \u007F\u0080sxPe};

		// Token: 0x04011569 RID: 71017
		[Token(Token = "0x4011569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA30")]
		private float HTbmvOD;

		// Token: 0x0401156A RID: 71018
		[Token(Token = "0x401156A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA34")]
		private float I\u0080rmS^{;

		// Token: 0x0401156B RID: 71019
		[Token(Token = "0x401156B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA38")]
		protected GameObject nTzxjLs;

		// Token: 0x0401156C RID: 71020
		[Token(Token = "0x401156C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA40")]
		protected ]\u0082VT^D| t\u0082qlzzD;

		// Token: 0x0401156D RID: 71021
		[Token(Token = "0x401156D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA48")]
		private float EUKNMg^;

		// Token: 0x0401156E RID: 71022
		[Token(Token = "0x401156E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131714", Offset = "0x1131714")]
		private dI[\u0082|T\u0080 <HSqpBE[>k__BackingField;

		// Token: 0x0401156F RID: 71023
		[Token(Token = "0x401156F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly float n\u0082B~U;

		// Token: 0x04011570 RID: 71024
		[Token(Token = "0x4011570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float H^Wqet\u0081;

		// Token: 0x04011571 RID: 71025
		[Token(Token = "0x4011571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA58")]
		public float SkySurfingTotalDurationForLog;

		// Token: 0x04011572 RID: 71026
		[Token(Token = "0x4011572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5C")]
		public float SkyDivingTotalDurationForLog;

		// Token: 0x04011573 RID: 71027
		[Token(Token = "0x4011573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA60")]
		public uint SkySlidingPressBtnCountForLog;

		// Token: 0x04011574 RID: 71028
		[Token(Token = "0x4011574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA64")]
		public int SkyDivingSwitchPosTimes;

		// Token: 0x04011575 RID: 71029
		[Token(Token = "0x4011575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA68")]
		private float \u0081RUCc\u007Fg;

		// Token: 0x04011576 RID: 71030
		[Token(Token = "0x4011576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6C")]
		private float WAU{[UG;

		// Token: 0x04011577 RID: 71031
		[Token(Token = "0x4011577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA70")]
		public bool IsDieingOnParachute;

		// Token: 0x04011578 RID: 71032
		[Token(Token = "0x4011578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA78")]
		private Dictionary<Player.T[m, Player.yWKZ\u0081mf> zODEucn;

		// Token: 0x04011579 RID: 71033
		[Token(Token = "0x4011579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA80")]
		private bool \u007FrdNqUU;

		// Token: 0x0401157A RID: 71034
		[Token(Token = "0x401157A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA84")]
		private float s{\u0080SMBa;

		// Token: 0x0401157B RID: 71035
		[Token(Token = "0x401157B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA88")]
		private {QAb\u0082~u jOV~eXL;

		// Token: 0x0401157C RID: 71036
		[Token(Token = "0x401157C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA0")]
		private byte LoZ;

		// Token: 0x0401157D RID: 71037
		[Token(Token = "0x401157D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA4")]
		private kd[\u0080AVO B\u007FcXcVW;

		// Token: 0x0401157E RID: 71038
		[Token(Token = "0x401157E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA8")]
		private Vector3 pJhjYvS;

		// Token: 0x0401157F RID: 71039
		[Token(Token = "0x401157F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB4")]
		private bool \u0080OM\u0081NX{;

		// Token: 0x04011580 RID: 71040
		[Token(Token = "0x4011580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB8")]
		public Player.iX^^Yu| m_TeamParachuteCallBack;

		// Token: 0x04011581 RID: 71041
		[Token(Token = "0x4011581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC0")]
		public Player.\u007FRm~a\u0081[ m_OnPlayerPhysxStateSwtich;

		// Token: 0x04011582 RID: 71042
		[Token(Token = "0x4011582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC8")]
		public Player.QYId]Kn m_OnLeaderWantChangeTransfom;

		// Token: 0x04011583 RID: 71043
		[Token(Token = "0x4011583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD0")]
		private bool oCFebdJ;

		// Token: 0x04011584 RID: 71044
		[Token(Token = "0x4011584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD1")]
		private bool aF{jboX;

		// Token: 0x04011585 RID: 71045
		[Token(Token = "0x4011585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD2")]
		private bool j~Q|{jj;

		// Token: 0x04011586 RID: 71046
		[Token(Token = "0x4011586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD4")]
		private ResourceID YQqkZdC;

		// Token: 0x04011587 RID: 71047
		[Token(Token = "0x4011587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD8")]
		protected JECPJUw lY~esMs;

		// Token: 0x04011588 RID: 71048
		[Token(Token = "0x4011588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE0")]
		protected Collider aiGmema;

		// Token: 0x02002A5A RID: 10842
		[Token(Token = "0x2002A5A")]
		protected class E[OnOQS
		{
			// Token: 0x0600ED87 RID: 60807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED87")]
			[Address(RVA = "0x17004B8", Offset = "0x17004B8", VA = "0x7BBBF004B8")]
			public E[OnOQS({QAb\u0082~u {NRR\u0081yd, float LR{cUe\u0080, bool FexeocR = false)
			{
			}

			// Token: 0x0600ED88 RID: 60808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED88")]
			[Address(RVA = "0x1700578", Offset = "0x1700578", VA = "0x7BBBF00578")]
			public void yAM~bGB(float LR{cUe\u0080)
			{
			}

			// Token: 0x0600ED89 RID: 60809 RVA: 0x00043B18 File Offset: 0x00041D18
			[Token(Token = "0x600ED89")]
			[Address(RVA = "0x170060C", Offset = "0x170060C", VA = "0x7BBBF0060C")]
			public bool ALmmnH()
			{
				return default(bool);
			}

			// Token: 0x0600ED8A RID: 60810 RVA: 0x00043B30 File Offset: 0x00041D30
			[Token(Token = "0x600ED8A")]
			[Address(RVA = "0x17006F0", Offset = "0x17006F0", VA = "0x7BBBF006F0")]
			public {QAb\u0082~u MP\u0082`Y()
			{
				return default({QAb\u0082~u);
			}

			// Token: 0x0600ED8B RID: 60811 RVA: 0x00043B48 File Offset: 0x00041D48
			[Token(Token = "0x600ED8B")]
			[Address(RVA = "0x170065C", Offset = "0x170065C", VA = "0x7BBBF0065C")]
			public bool Bt^RO`()
			{
				return default(bool);
			}

			// Token: 0x04011589 RID: 71049
			[Token(Token = "0x4011589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private {QAb\u0082~u BhUcw{z;

			// Token: 0x0401158A RID: 71050
			[Token(Token = "0x401158A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float \u007FSB}n]s;

			// Token: 0x0401158B RID: 71051
			[Token(Token = "0x401158B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool tt{T^Rp;
		}

		// Token: 0x02002A5B RID: 10843
		[Token(Token = "0x2002A5B")]
		public enum T[m
		{
			// Token: 0x0401158D RID: 71053
			[Token(Token = "0x401158D")]
			Walking,
			// Token: 0x0401158E RID: 71054
			[Token(Token = "0x401158E")]
			Falling,
			// Token: 0x0401158F RID: 71055
			[Token(Token = "0x401158F")]
			Parachuting,
			// Token: 0x04011590 RID: 71056
			[Token(Token = "0x4011590")]
			OnBoard,
			// Token: 0x04011591 RID: 71057
			[Token(Token = "0x4011591")]
			SkyDiving,
			// Token: 0x04011592 RID: 71058
			[Token(Token = "0x4011592")]
			HitFly,
			// Token: 0x04011593 RID: 71059
			[Token(Token = "0x4011593")]
			Swimming,
			// Token: 0x04011594 RID: 71060
			[Token(Token = "0x4011594")]
			OnStrop,
			// Token: 0x04011595 RID: 71061
			[Token(Token = "0x4011595")]
			Football,
			// Token: 0x04011596 RID: 71062
			[Token(Token = "0x4011596")]
			JetFly,
			// Token: 0x04011597 RID: 71063
			[Token(Token = "0x4011597")]
			Gliding,
			// Token: 0x04011598 RID: 71064
			[Token(Token = "0x4011598")]
			OnGrapplingHook,
			// Token: 0x04011599 RID: 71065
			[Token(Token = "0x4011599")]
			Skateboarding,
			// Token: 0x0401159A RID: 71066
			[Token(Token = "0x401159A")]
			OnFerrisWheel
		}

		// Token: 0x02002A5C RID: 10844
		[Token(Token = "0x2002A5C")]
		public enum Nn
		{
			// Token: 0x0401159C RID: 71068
			[Token(Token = "0x401159C")]
			None,
			// Token: 0x0401159D RID: 71069
			[Token(Token = "0x401159D")]
			FastRun
		}

		// Token: 0x02002A5D RID: 10845
		[Token(Token = "0x2002A5D")]
		public enum \u0082\u0080]T~di
		{
			// Token: 0x0401159F RID: 71071
			[Token(Token = "0x401159F")]
			None,
			// Token: 0x040115A0 RID: 71072
			[Token(Token = "0x40115A0")]
			Attack,
			// Token: 0x040115A1 RID: 71073
			[Token(Token = "0x40115A1")]
			Defense
		}

		// Token: 0x02002A5E RID: 10846
		[Token(Token = "0x2002A5E")]
		protected class RbWp]Ul
		{
			// Token: 0x0600ED8C RID: 60812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED8C")]
			[Address(RVA = "0x1702800", Offset = "0x1702800", VA = "0x7BBBF02800")]
			public RbWp]Ul()
			{
			}

			// Token: 0x040115A2 RID: 71074
			[Token(Token = "0x40115A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public aZ hv;

			// Token: 0x040115A3 RID: 71075
			[Token(Token = "0x40115A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint D[Gv;

			// Token: 0x040115A4 RID: 71076
			[Token(Token = "0x40115A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte HHGoU;

			// Token: 0x040115A5 RID: 71077
			[Token(Token = "0x40115A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 \u0082\u0082wdDek;
		}

		// Token: 0x02002A5F RID: 10847
		[Token(Token = "0x2002A5F")]
		public enum WJA\u0080Xxv
		{
			// Token: 0x040115A7 RID: 71079
			[Token(Token = "0x40115A7")]
			NONE,
			// Token: 0x040115A8 RID: 71080
			[Token(Token = "0x40115A8")]
			TeammateRescure,
			// Token: 0x040115A9 RID: 71081
			[Token(Token = "0x40115A9")]
			SelfRescure
		}

		// Token: 0x02002A60 RID: 10848
		[Token(Token = "0x2002A60")]
		public enum o{jS
		{
			// Token: 0x040115AB RID: 71083
			[Token(Token = "0x40115AB")]
			None,
			// Token: 0x040115AC RID: 71084
			[Token(Token = "0x40115AC")]
			Opened,
			// Token: 0x040115AD RID: 71085
			[Token(Token = "0x40115AD")]
			Closed,
			// Token: 0x040115AE RID: 71086
			[Token(Token = "0x40115AE")]
			Openning
		}

		// Token: 0x02002A61 RID: 10849
		[Token(Token = "0x2002A61")]
		public class yyEoKfi
		{
			// Token: 0x0600ED8D RID: 60813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED8D")]
			[Address(RVA = "0x1708D8C", Offset = "0x1708D8C", VA = "0x7BBBF08D8C")]
			public void LnopbsY()
			{
			}

			// Token: 0x0600ED8E RID: 60814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED8E")]
			[Address(RVA = "0x1708DBC", Offset = "0x1708DBC", VA = "0x7BBBF08DBC")]
			public void QM~L|go()
			{
			}

			// Token: 0x0600ED8F RID: 60815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED8F")]
			[Address(RVA = "0x1708DEC", Offset = "0x1708DEC", VA = "0x7BBBF08DEC")]
			public void I()
			{
			}

			// Token: 0x170010C8 RID: 4296
			// (get) Token: 0x0600ED90 RID: 60816 RVA: 0x00043B60 File Offset: 0x00041D60
			[Token(Token = "0x170010C8")]
			public bool FY\u0081PFg
			{
				[Token(Token = "0x600ED90")]
				[Address(RVA = "0x1708DF4", Offset = "0x1708DF4", VA = "0x7BBBF08DF4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600ED91 RID: 60817 RVA: 0x00043B78 File Offset: 0x00041D78
			[Token(Token = "0x600ED91")]
			[Address(RVA = "0x1708E20", Offset = "0x1708E20", VA = "0x7BBBF08E20")]
			public float AIAGHUW()
			{
				return 0f;
			}

			// Token: 0x0600ED92 RID: 60818 RVA: 0x00043B90 File Offset: 0x00041D90
			[Token(Token = "0x600ED92")]
			[Address(RVA = "0x1708E8C", Offset = "0x1708E8C", VA = "0x7BBBF08E8C")]
			public float |}xveV\u0081()
			{
				return 0f;
			}

			// Token: 0x0600ED93 RID: 60819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED93")]
			[Address(RVA = "0x1708F10", Offset = "0x1708F10", VA = "0x7BBBF08F10")]
			public void zZ|A}\u007FK(float tjREevq)
			{
			}

			// Token: 0x0600ED94 RID: 60820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ED94")]
			[Address(RVA = "0x1708F48", Offset = "0x1708F48", VA = "0x7BBBF08F48")]
			public yyEoKfi()
			{
			}

			// Token: 0x040115AF RID: 71087
			[Token(Token = "0x40115AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float tLN\u007Fxy;

			// Token: 0x040115B0 RID: 71088
			[Token(Token = "0x40115B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			protected float {{\u0082]a\u007F|;
		}

		// Token: 0x02002A62 RID: 10850
		// (Invoke) Token: 0x0600ED96 RID: 60822
		[Token(Token = "0x2002A62")]
		public delegate bool X|\u0082sRVj(float \u0081}x[tOF, float OsUltaA);

		// Token: 0x02002A63 RID: 10851
		[Token(Token = "0x2002A63")]
		public enum psnG
		{
			// Token: 0x040115B2 RID: 71090
			[Token(Token = "0x40115B2")]
			SkillNoiseDampingAndBleed
		}

		// Token: 0x02002A64 RID: 10852
		[Token(Token = "0x2002A64")]
		public enum \u0081HFicwE
		{
			// Token: 0x040115B4 RID: 71092
			[Token(Token = "0x40115B4")]
			Show,
			// Token: 0x040115B5 RID: 71093
			[Token(Token = "0x40115B5")]
			Hide,
			// Token: 0x040115B6 RID: 71094
			[Token(Token = "0x40115B6")]
			Fall
		}

		// Token: 0x02002A65 RID: 10853
		[Token(Token = "0x2002A65")]
		public class }Tv]tpI
		{
			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x0600ED99 RID: 60825 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600ED9A RID: 60826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170010C9")]
			public Player.yWKZ\u0081mf ~itUbUk
			{
				[Token(Token = "0x600ED99")]
				[Address(RVA = "0x1709120", Offset = "0x1709120", VA = "0x7BBBF09120")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A7DC", Offset = "0x114A7DC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600ED9A")]
				[Address(RVA = "0x1709128", Offset = "0x1709128", VA = "0x7BBBF09128")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A7EC", Offset = "0x114A7EC")]
				private set
				{
				}
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x0600ED9B RID: 60827 RVA: 0x00043BA8 File Offset: 0x00041DA8
			[Token(Token = "0x170010CA")]
			public Player.T[m yWKZ\u0081mf
			{
				[Token(Token = "0x600ED9B")]
				[Address(RVA = "0x1706C9C", Offset = "0x1706C9C", VA = "0x7BBBF06C9C")]
				get
				{
					return Player.T[m.Walking;
				}
			}

			// Token: 0x170010CB RID: 4299
			// (get) Token: 0x0600ED9C RID: 60828 RVA: 0x00043BC0 File Offset: 0x00041DC0
			[Token(Token = "0x170010CB")]
			public VCDxuoO Khb\u0080Bqa
			{
				[Token(Token = "0x600ED9C")]
				[Address(RVA = "0x1709130", Offset = "0x1709130", VA = "0x7BBBF09130")]
				get
				{
					return VCDxuoO.EPHYSXPOSE_STANDING;
				}
			}

			// Token: 0x170010CC RID: 4300
			// (get) Token: 0x0600ED9D RID: 60829 RVA: 0x00043BD8 File Offset: 0x00041DD8
			[Token(Token = "0x170010CC")]
			public bool lZbk}\u0080\u007F
			{
				[Token(Token = "0x600ED9D")]
				[Address(RVA = "0x1709148", Offset = "0x1709148", VA = "0x7BBBF09148")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x0600ED9E RID: 60830 RVA: 0x00043BF0 File Offset: 0x00041DF0
			[Token(Token = "0x170010CD")]
			public bool RetK^ga
			{
				[Token(Token = "0x600ED9E")]
				[Address(RVA = "0x17091B8", Offset = "0x17091B8", VA = "0x7BBBF091B8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010CE RID: 4302
			// (get) Token: 0x0600ED9F RID: 60831 RVA: 0x00043C08 File Offset: 0x00041E08
			[Token(Token = "0x170010CE")]
			public bool ^iXe\u007FU^
			{
				[Token(Token = "0x600ED9F")]
				[Address(RVA = "0x1709208", Offset = "0x1709208", VA = "0x7BBBF09208")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010CF RID: 4303
			// (get) Token: 0x0600EDA0 RID: 60832 RVA: 0x00043C20 File Offset: 0x00041E20
			[Token(Token = "0x170010CF")]
			public bool qGVWm\u0082H
			{
				[Token(Token = "0x600EDA0")]
				[Address(RVA = "0x1709294", Offset = "0x1709294", VA = "0x7BBBF09294")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D0 RID: 4304
			// (get) Token: 0x0600EDA1 RID: 60833 RVA: 0x00043C38 File Offset: 0x00041E38
			[Token(Token = "0x170010D0")]
			public bool pPj{CwT
			{
				[Token(Token = "0x600EDA1")]
				[Address(RVA = "0x17092E4", Offset = "0x17092E4", VA = "0x7BBBF092E4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D1 RID: 4305
			// (get) Token: 0x0600EDA2 RID: 60834 RVA: 0x00043C50 File Offset: 0x00041E50
			[Token(Token = "0x170010D1")]
			public bool L\u0081Ue
			{
				[Token(Token = "0x600EDA2")]
				[Address(RVA = "0x1709338", Offset = "0x1709338", VA = "0x7BBBF09338")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D2 RID: 4306
			// (get) Token: 0x0600EDA3 RID: 60835 RVA: 0x00043C68 File Offset: 0x00041E68
			[Token(Token = "0x170010D2")]
			public bool GUWe
			{
				[Token(Token = "0x600EDA3")]
				[Address(RVA = "0x17093A0", Offset = "0x17093A0", VA = "0x7BBBF093A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D3 RID: 4307
			// (get) Token: 0x0600EDA4 RID: 60836 RVA: 0x00043C80 File Offset: 0x00041E80
			[Token(Token = "0x170010D3")]
			public bool my[vWQw
			{
				[Token(Token = "0x600EDA4")]
				[Address(RVA = "0x17094A0", Offset = "0x17094A0", VA = "0x7BBBF094A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D4 RID: 4308
			// (get) Token: 0x0600EDA5 RID: 60837 RVA: 0x00043C98 File Offset: 0x00041E98
			[Token(Token = "0x170010D4")]
			public bool avkBJz\u0080
			{
				[Token(Token = "0x600EDA5")]
				[Address(RVA = "0x17094F4", Offset = "0x17094F4", VA = "0x7BBBF094F4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D5 RID: 4309
			// (get) Token: 0x0600EDA6 RID: 60838 RVA: 0x00043CB0 File Offset: 0x00041EB0
			[Token(Token = "0x170010D5")]
			public bool LSws]QU
			{
				[Token(Token = "0x600EDA6")]
				[Address(RVA = "0x1709550", Offset = "0x1709550", VA = "0x7BBBF09550")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D6 RID: 4310
			// (get) Token: 0x0600EDA7 RID: 60839 RVA: 0x00043CC8 File Offset: 0x00041EC8
			[Token(Token = "0x170010D6")]
			public bool {Du\u0082\u0081[\u0080
			{
				[Token(Token = "0x600EDA7")]
				[Address(RVA = "0x17095A4", Offset = "0x17095A4", VA = "0x7BBBF095A4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D7 RID: 4311
			// (get) Token: 0x0600EDA8 RID: 60840 RVA: 0x00043CE0 File Offset: 0x00041EE0
			[Token(Token = "0x170010D7")]
			public bool vZNUFHA
			{
				[Token(Token = "0x600EDA8")]
				[Address(RVA = "0x17095F4", Offset = "0x17095F4", VA = "0x7BBBF095F4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D8 RID: 4312
			// (get) Token: 0x0600EDA9 RID: 60841 RVA: 0x00043CF8 File Offset: 0x00041EF8
			[Token(Token = "0x170010D8")]
			public bool y\u0082}moqQ
			{
				[Token(Token = "0x600EDA9")]
				[Address(RVA = "0x1709648", Offset = "0x1709648", VA = "0x7BBBF09648")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170010D9 RID: 4313
			// (get) Token: 0x0600EDAA RID: 60842 RVA: 0x00043D10 File Offset: 0x00041F10
			[Token(Token = "0x170010D9")]
			public bool rYP\u0081z\u0081p
			{
				[Token(Token = "0x600EDAA")]
				[Address(RVA = "0x170969C", Offset = "0x170969C", VA = "0x7BBBF0969C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600EDAB RID: 60843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDAB")]
			[Address(RVA = "0x17096FC", Offset = "0x17096FC", VA = "0x7BBBF096FC")]
			public }Tv]tpI(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDAC RID: 60844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDAC")]
			[Address(RVA = "0x17097AC", Offset = "0x17097AC", VA = "0x7BBBF097AC")]
			public void T]Ir|w^(Player.yWKZ\u0081mf JXT\u0081\u0080QL)
			{
			}

			// Token: 0x040115B7 RID: 71095
			[Token(Token = "0x40115B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Player QVo~EHm;

			// Token: 0x040115B8 RID: 71096
			[Token(Token = "0x40115B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131724", Offset = "0x1131724")]
			private Player.yWKZ\u0081mf <\u0080w|~pyS>k__BackingField;

			// Token: 0x040115B9 RID: 71097
			[Token(Token = "0x40115B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 ~o\u007FMZrp;

			// Token: 0x040115BA RID: 71098
			[Token(Token = "0x40115BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 N~}F|LK;

			// Token: 0x040115BB RID: 71099
			[Token(Token = "0x40115BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float QRSCfZ];

			// Token: 0x040115BC RID: 71100
			[Token(Token = "0x40115BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float ]l\u007FBhj;

			// Token: 0x040115BD RID: 71101
			[Token(Token = "0x40115BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 L\u0080FEeoZ;
		}

		// Token: 0x02002A66 RID: 10854
		[Token(Token = "0x2002A66")]
		public enum }Ia|XVW
		{
			// Token: 0x040115BF RID: 71103
			[Token(Token = "0x40115BF")]
			BUFF_DOT = 1,
			// Token: 0x040115C0 RID: 71104
			[Token(Token = "0x40115C0")]
			BUFF_SKIN
		}

		// Token: 0x02002A67 RID: 10855
		[Token(Token = "0x2002A67")]
		public abstract class yWKZ\u0081mf
		{
			// Token: 0x170010DA RID: 4314
			// (get) Token: 0x0600EDAD RID: 60845 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600EDAE RID: 60846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170010DA")]
			private protected Player lXS
			{
				[Token(Token = "0x600EDAD")]
				[Address(RVA = "0x16FFC54", Offset = "0x16FFC54", VA = "0x7BBBEFFC54")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A7FC", Offset = "0x114A7FC")]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600EDAE")]
				[Address(RVA = "0x17089F0", Offset = "0x17089F0", VA = "0x7BBBF089F0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114A80C", Offset = "0x114A80C")]
				private set
				{
				}
			}

			// Token: 0x0600EDAF RID: 60847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDAF")]
			[Address(RVA = "0x16FF8D0", Offset = "0x16FF8D0", VA = "0x7BBBEFF8D0")]
			public yWKZ\u0081mf(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDB0 RID: 60848
			[Token(Token = "0x600EDB0")]
			public abstract Player.T[m K}o^rf[();

			// Token: 0x0600EDB1 RID: 60849 RVA: 0x00043D28 File Offset: 0x00041F28
			[Token(Token = "0x600EDB1")]
			[Address(RVA = "0x17089F8", Offset = "0x17089F8", VA = "0x7BBBF089F8")]
			public VCDxuoO ft[U]oA()
			{
				return VCDxuoO.EPHYSXPOSE_STANDING;
			}

			// Token: 0x0600EDB2 RID: 60850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB2")]
			[Address(RVA = "0x1708A00", Offset = "0x1708A00", VA = "0x7BBBF08A00")]
			public void vOviNFS(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDB3 RID: 60851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB3")]
			[Address(RVA = "0x1708CCC", Offset = "0x1708CCC", VA = "0x7BBBF08CCC")]
			public void mseVN(VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDB4 RID: 60852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB4")]
			[Address(RVA = "0x1708D40", Offset = "0x1708D40", VA = "0x7BBBF08D40")]
			public void w~}AyC{(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDB5 RID: 60853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB5")]
			[Address(RVA = "0x1708A4C", Offset = "0x1708A4C", VA = "0x7BBBF08A4C")]
			protected void BcKg}Bf(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDB6 RID: 60854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB6")]
			[Address(RVA = "0x1708D34", Offset = "0x1708D34", VA = "0x7BBBF08D34")]
			protected void hFnP]aA(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDB7 RID: 60855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB7")]
			[Address(RVA = "0x1701460", Offset = "0x1701460", VA = "0x7BBBF01460", Slot = "5")]
			protected virtual void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}

			// Token: 0x0600EDB8 RID: 60856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB8")]
			[Address(RVA = "0x1701280", Offset = "0x1701280", VA = "0x7BBBF01280", Slot = "6")]
			protected virtual void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EDB9 RID: 60857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDB9")]
			[Address(RVA = "0x17037D4", Offset = "0x17037D4", VA = "0x7BBBF037D4", Slot = "7")]
			protected virtual void niswrhm(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDBA RID: 60858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDBA")]
			[Address(RVA = "0x1708D7C", Offset = "0x1708D7C", VA = "0x7BBBF08D7C", Slot = "8")]
			protected virtual void GIZJBXC(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDBB RID: 60859 RVA: 0x00043D40 File Offset: 0x00041F40
			[Token(Token = "0x600EDBB")]
			[Address(RVA = "0x1708D80", Offset = "0x1708D80", VA = "0x7BBBF08D80", Slot = "9")]
			protected virtual bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x040115C1 RID: 71105
			[Token(Token = "0x40115C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected VCDxuoO tHxZ\u0082EH;

			// Token: 0x040115C2 RID: 71106
			[Token(Token = "0x40115C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131734", Offset = "0x1131734")]
			private Player <RHELKli>k__BackingField;
		}

		// Token: 0x02002A68 RID: 10856
		[Token(Token = "0x2002A68")]
		private class [ep\u0080oeZ : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDBC RID: 60860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDBC")]
			[Address(RVA = "0x1703D54", Offset = "0x1703D54", VA = "0x7BBBF03D54")]
			public [ep\u0080oeZ(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDBD RID: 60861 RVA: 0x00043D58 File Offset: 0x00041F58
			[Token(Token = "0x600EDBD")]
			[Address(RVA = "0x1703D80", Offset = "0x1703D80", VA = "0x7BBBF03D80", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDBE RID: 60862 RVA: 0x00043D70 File Offset: 0x00041F70
			[Token(Token = "0x600EDBE")]
			[Address(RVA = "0x1703D88", Offset = "0x1703D88", VA = "0x7BBBF03D88", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x0600EDBF RID: 60863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDBF")]
			[Address(RVA = "0x1703DB8", Offset = "0x1703DB8", VA = "0x7BBBF03DB8", Slot = "7")]
			protected override void niswrhm(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDC0 RID: 60864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC0")]
			[Address(RVA = "0x1704AAC", Offset = "0x1704AAC", VA = "0x7BBBF04AAC", Slot = "8")]
			protected override void GIZJBXC(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC1 RID: 60865 RVA: 0x00043D88 File Offset: 0x00041F88
			[Token(Token = "0x600EDC1")]
			[Address(RVA = "0x1705EEC", Offset = "0x1705EEC", VA = "0x7BBBF05EEC")]
			private static bool D|xGaiY(VCDxuoO \u0082Ujwl\u0080f)
			{
				return default(bool);
			}

			// Token: 0x0600EDC2 RID: 60866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC2")]
			[Address(RVA = "0x1705748", Offset = "0x1705748", VA = "0x7BBBF05748")]
			private void GxAgbv[(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC3 RID: 60867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC3")]
			[Address(RVA = "0x170568C", Offset = "0x170568C", VA = "0x7BBBF0568C")]
			private void ukkEiA\u0081(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC4 RID: 60868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC4")]
			[Address(RVA = "0x1704AF0", Offset = "0x1704AF0", VA = "0x7BBBF04AF0")]
			private void A\u0082TaJ\u0080l(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC5 RID: 60869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC5")]
			[Address(RVA = "0x1705064", Offset = "0x1705064", VA = "0x7BBBF05064")]
			private void GGgQ\u0080lY(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC6 RID: 60870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC6")]
			[Address(RVA = "0x17051B8", Offset = "0x17051B8", VA = "0x7BBBF051B8")]
			private void DLSFgt[(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC7 RID: 60871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC7")]
			[Address(RVA = "0x1705620", Offset = "0x1705620", VA = "0x7BBBF05620")]
			private void epWuKM[(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC8 RID: 60872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC8")]
			[Address(RVA = "0x1705DA4", Offset = "0x1705DA4", VA = "0x7BBBF05DA4")]
			private void bfJDDWm(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDC9 RID: 60873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDC9")]
			[Address(RVA = "0x1705E84", Offset = "0x1705E84", VA = "0x7BBBF05E84")]
			private void iaXAI\u0081E(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDCA RID: 60874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDCA")]
			[Address(RVA = "0x1703FA8", Offset = "0x1703FA8", VA = "0x7BBBF03FA8")]
			private void zy~vgNY(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDCB RID: 60875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDCB")]
			[Address(RVA = "0x1703E28", Offset = "0x1703E28", VA = "0x7BBBF03E28")]
			private void Zgn|zvJ(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDCC RID: 60876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDCC")]
			[Address(RVA = "0x1704214", Offset = "0x1704214", VA = "0x7BBBF04214")]
			private void XxX\u0080iDE(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDCD RID: 60877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDCD")]
			[Address(RVA = "0x1704398", Offset = "0x1704398", VA = "0x7BBBF04398")]
			private void N\u0080eCjml(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDCE RID: 60878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDCE")]
			[Address(RVA = "0x17043CC", Offset = "0x17043CC", VA = "0x7BBBF043CC")]
			private void y|]Z\u0080Bf(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDCF RID: 60879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDCF")]
			[Address(RVA = "0x1704998", Offset = "0x1704998", VA = "0x7BBBF04998")]
			private void hb\u0082\u007FAax(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDD0 RID: 60880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD0")]
			[Address(RVA = "0x1704A44", Offset = "0x1704A44", VA = "0x7BBBF04A44")]
			private void |Z]TUmw(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}
		}

		// Token: 0x02002A69 RID: 10857
		[Token(Token = "0x2002A69")]
		private class Ulw}XkU : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDD1 RID: 60881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD1")]
			[Address(RVA = "0x170297C", Offset = "0x170297C", VA = "0x7BBBF0297C")]
			public Ulw}XkU(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDD2 RID: 60882 RVA: 0x00043DA0 File Offset: 0x00041FA0
			[Token(Token = "0x600EDD2")]
			[Address(RVA = "0x17029A8", Offset = "0x17029A8", VA = "0x7BBBF029A8", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDD3 RID: 60883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD3")]
			[Address(RVA = "0x17029B0", Offset = "0x17029B0", VA = "0x7BBBF029B0", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}

			// Token: 0x0600EDD4 RID: 60884 RVA: 0x00043DB8 File Offset: 0x00041FB8
			[Token(Token = "0x600EDD4")]
			[Address(RVA = "0x1702A5C", Offset = "0x1702A5C", VA = "0x7BBBF02A5C", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x0600EDD5 RID: 60885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD5")]
			[Address(RVA = "0x1702A90", Offset = "0x1702A90", VA = "0x7BBBF02A90", Slot = "8")]
			protected override void GIZJBXC(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDD6 RID: 60886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD6")]
			[Address(RVA = "0x1703698", Offset = "0x1703698", VA = "0x7BBBF03698")]
			private void Fp()
			{
			}

			// Token: 0x0600EDD7 RID: 60887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD7")]
			[Address(RVA = "0x1702AD4", Offset = "0x1702AD4", VA = "0x7BBBF02AD4")]
			private void A\u0082TaJ\u0080l(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDD8 RID: 60888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD8")]
			[Address(RVA = "0x170309C", Offset = "0x170309C", VA = "0x7BBBF0309C")]
			private void f\u0080jcFFi(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDD9 RID: 60889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDD9")]
			[Address(RVA = "0x1703378", Offset = "0x1703378", VA = "0x7BBBF03378")]
			private void {j\u0080ZhDa(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDDA RID: 60890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDDA")]
			[Address(RVA = "0x17034EC", Offset = "0x17034EC", VA = "0x7BBBF034EC")]
			private void bRcgKQb(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDDB RID: 60891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDDB")]
			[Address(RVA = "0x1703630", Offset = "0x1703630", VA = "0x7BBBF03630")]
			private void CGJH~~m(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDDC RID: 60892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDDC")]
			[Address(RVA = "0x17031B8", Offset = "0x17031B8", VA = "0x7BBBF031B8")]
			private void K\u0081eJ\u007FOq(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDDD RID: 60893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDDD")]
			[Address(RVA = "0x1703770", Offset = "0x1703770", VA = "0x7BBBF03770", Slot = "7")]
			protected override void niswrhm(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}
		}

		// Token: 0x02002A6A RID: 10858
		[Token(Token = "0x2002A6A")]
		private class \u0081}\u0080|DIQ : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDDE RID: 60894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDDE")]
			[Address(RVA = "0x170A0FC", Offset = "0x170A0FC", VA = "0x7BBBF0A0FC")]
			public \u0081}\u0080|DIQ(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDDF RID: 60895 RVA: 0x00043DD0 File Offset: 0x00041FD0
			[Token(Token = "0x600EDDF")]
			[Address(RVA = "0x170A128", Offset = "0x170A128", VA = "0x7BBBF0A128", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDE0 RID: 60896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDE0")]
			[Address(RVA = "0x170A130", Offset = "0x170A130", VA = "0x7BBBF0A130", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EDE1 RID: 60897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDE1")]
			[Address(RVA = "0x170A20C", Offset = "0x170A20C", VA = "0x7BBBF0A20C", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}
		}

		// Token: 0x02002A6B RID: 10859
		[Token(Token = "0x2002A6B")]
		private class HuVnF\u007FD : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDE2 RID: 60898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDE2")]
			[Address(RVA = "0x1700FDC", Offset = "0x1700FDC", VA = "0x7BBBF00FDC")]
			public HuVnF\u007FD(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDE3 RID: 60899 RVA: 0x00043DE8 File Offset: 0x00041FE8
			[Token(Token = "0x600EDE3")]
			[Address(RVA = "0x1701008", Offset = "0x1701008", VA = "0x7BBBF01008", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDE4 RID: 60900 RVA: 0x00043E00 File Offset: 0x00042000
			[Token(Token = "0x600EDE4")]
			[Address(RVA = "0x1701010", Offset = "0x1701010", VA = "0x7BBBF01010", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x0600EDE5 RID: 60901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDE5")]
			[Address(RVA = "0x1701030", Offset = "0x1701030", VA = "0x7BBBF01030", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EDE6 RID: 60902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDE6")]
			[Address(RVA = "0x1701284", Offset = "0x1701284", VA = "0x7BBBF01284", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}
		}

		// Token: 0x02002A6C RID: 10860
		[Token(Token = "0x2002A6C")]
		private class ^CU{rv^ : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDE7 RID: 60903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDE7")]
			[Address(RVA = "0x1705F10", Offset = "0x1705F10", VA = "0x7BBBF05F10")]
			public ^CU{rv^(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDE8 RID: 60904 RVA: 0x00043E18 File Offset: 0x00042018
			[Token(Token = "0x600EDE8")]
			[Address(RVA = "0x1705F3C", Offset = "0x1705F3C", VA = "0x7BBBF05F3C", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDE9 RID: 60905 RVA: 0x00043E30 File Offset: 0x00042030
			[Token(Token = "0x600EDE9")]
			[Address(RVA = "0x1705F44", Offset = "0x1705F44", VA = "0x7BBBF05F44", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x0600EDEA RID: 60906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDEA")]
			[Address(RVA = "0x1705F5C", Offset = "0x1705F5C", VA = "0x7BBBF05F5C", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EDEB RID: 60907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDEB")]
			[Address(RVA = "0x1706070", Offset = "0x1706070", VA = "0x7BBBF06070", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}

			// Token: 0x0600EDEC RID: 60908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDEC")]
			[Address(RVA = "0x17063F8", Offset = "0x17063F8", VA = "0x7BBBF063F8", Slot = "8")]
			protected override void GIZJBXC(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDED RID: 60909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDED")]
			[Address(RVA = "0x1706414", Offset = "0x1706414", VA = "0x7BBBF06414")]
			private void jc^zcO{(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDEE RID: 60910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDEE")]
			[Address(RVA = "0x170681C", Offset = "0x170681C", VA = "0x7BBBF0681C")]
			private void jrEElq}(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}
		}

		// Token: 0x02002A6D RID: 10861
		[Token(Token = "0x2002A6D")]
		private class G\u0080PjPtY : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDEF RID: 60911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDEF")]
			[Address(RVA = "0x1700704", Offset = "0x1700704", VA = "0x7BBBF00704")]
			public G\u0080PjPtY(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDF0 RID: 60912 RVA: 0x00043E48 File Offset: 0x00042048
			[Token(Token = "0x600EDF0")]
			[Address(RVA = "0x1700730", Offset = "0x1700730", VA = "0x7BBBF00730", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDF1 RID: 60913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDF1")]
			[Address(RVA = "0x1700738", Offset = "0x1700738", VA = "0x7BBBF00738", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EDF2 RID: 60914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDF2")]
			[Address(RVA = "0x1700A50", Offset = "0x1700A50", VA = "0x7BBBF00A50", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}
		}

		// Token: 0x02002A6E RID: 10862
		[Token(Token = "0x2002A6E")]
		private class KUk{\u0080XW : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDF3 RID: 60915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDF3")]
			[Address(RVA = "0x1701464", Offset = "0x1701464", VA = "0x7BBBF01464")]
			public KUk{\u0080XW(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDF4 RID: 60916 RVA: 0x00043E60 File Offset: 0x00042060
			[Token(Token = "0x600EDF4")]
			[Address(RVA = "0x1701490", Offset = "0x1701490", VA = "0x7BBBF01490", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDF5 RID: 60917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDF5")]
			[Address(RVA = "0x1701498", Offset = "0x1701498", VA = "0x7BBBF01498", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EDF6 RID: 60918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDF6")]
			[Address(RVA = "0x170171C", Offset = "0x170171C", VA = "0x7BBBF0171C", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}
		}

		// Token: 0x02002A6F RID: 10863
		[Token(Token = "0x2002A6F")]
		private class DgPncTQ : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EDF7 RID: 60919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDF7")]
			[Address(RVA = "0x16FF8A4", Offset = "0x16FF8A4", VA = "0x7BBBEFF8A4")]
			public DgPncTQ(Player Foy[QIo)
			{
			}

			// Token: 0x0600EDF8 RID: 60920 RVA: 0x00043E78 File Offset: 0x00042078
			[Token(Token = "0x600EDF8")]
			[Address(RVA = "0x16FF8FC", Offset = "0x16FF8FC", VA = "0x7BBBEFF8FC", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EDF9 RID: 60921 RVA: 0x00043E90 File Offset: 0x00042090
			[Token(Token = "0x600EDF9")]
			[Address(RVA = "0x16FF904", Offset = "0x16FF904", VA = "0x7BBBEFF904", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x0600EDFA RID: 60922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDFA")]
			[Address(RVA = "0x16FF924", Offset = "0x16FF924", VA = "0x7BBBEFF924", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EDFB RID: 60923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDFB")]
			[Address(RVA = "0x16FFC5C", Offset = "0x16FFC5C", VA = "0x7BBBEFFC5C", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}

			// Token: 0x0600EDFC RID: 60924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDFC")]
			[Address(RVA = "0x16FFEB8", Offset = "0x16FFEB8", VA = "0x7BBBEFFEB8", Slot = "8")]
			protected override void GIZJBXC(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDFD RID: 60925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDFD")]
			[Address(RVA = "0x1700210", Offset = "0x1700210", VA = "0x7BBBF00210", Slot = "7")]
			protected override void niswrhm(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EDFE RID: 60926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDFE")]
			[Address(RVA = "0x16FFEE0", Offset = "0x16FFEE0", VA = "0x7BBBEFFEE0")]
			private void \u0081Tj\u0080cUx(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EDFF RID: 60927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EDFF")]
			[Address(RVA = "0x16FFFEC", Offset = "0x16FFFEC", VA = "0x7BBBEFFFEC")]
			private void Qnd\u0080~eD(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EE00 RID: 60928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE00")]
			[Address(RVA = "0x1700034", Offset = "0x1700034", VA = "0x7BBBF00034")]
			private void v\u0081~\u0081ljQ(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EE01 RID: 60929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE01")]
			[Address(RVA = "0x1700224", Offset = "0x1700224", VA = "0x7BBBF00224")]
			private void Jl|Y[nN(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}
		}

		// Token: 0x02002A70 RID: 10864
		[Token(Token = "0x2002A70")]
		private class eVjQgVp : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EE02 RID: 60930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE02")]
			[Address(RVA = "0x17078DC", Offset = "0x17078DC", VA = "0x7BBBF078DC")]
			public eVjQgVp(Player Foy[QIo)
			{
			}

			// Token: 0x0600EE03 RID: 60931 RVA: 0x00043EA8 File Offset: 0x000420A8
			[Token(Token = "0x600EE03")]
			[Address(RVA = "0x1707908", Offset = "0x1707908", VA = "0x7BBBF07908", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}
		}

		// Token: 0x02002A71 RID: 10865
		[Token(Token = "0x2002A71")]
		private class <<EMPTY_NAME>> : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EE04 RID: 60932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE04")]
			[Address(RVA = "0x1706CB4", Offset = "0x1706CB4", VA = "0x7BBBF06CB4")]
			public <<EMPTY_NAME>>(Player Foy[QIo)
			{
			}

			// Token: 0x0600EE05 RID: 60933 RVA: 0x00043EC0 File Offset: 0x000420C0
			[Token(Token = "0x600EE05")]
			[Address(RVA = "0x1706CE0", Offset = "0x1706CE0", VA = "0x7BBBF06CE0", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EE06 RID: 60934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE06")]
			[Address(RVA = "0x1706CE8", Offset = "0x1706CE8", VA = "0x7BBBF06CE8", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EE07 RID: 60935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE07")]
			[Address(RVA = "0x1706D84", Offset = "0x1706D84", VA = "0x7BBBF06D84", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}
		}

		// Token: 0x02002A72 RID: 10866
		[Token(Token = "0x2002A72")]
		private class srSrnIE : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EE08 RID: 60936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE08")]
			[Address(RVA = "0x17085C8", Offset = "0x17085C8", VA = "0x7BBBF085C8")]
			public srSrnIE(Player Foy[QIo)
			{
			}

			// Token: 0x0600EE09 RID: 60937 RVA: 0x00043ED8 File Offset: 0x000420D8
			[Token(Token = "0x600EE09")]
			[Address(RVA = "0x17085F4", Offset = "0x17085F4", VA = "0x7BBBF085F4", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EE0A RID: 60938 RVA: 0x00043EF0 File Offset: 0x000420F0
			[Token(Token = "0x600EE0A")]
			[Address(RVA = "0x17085FC", Offset = "0x17085FC", VA = "0x7BBBF085FC", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x0600EE0B RID: 60939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE0B")]
			[Address(RVA = "0x1708614", Offset = "0x1708614", VA = "0x7BBBF08614", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EE0C RID: 60940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE0C")]
			[Address(RVA = "0x1708674", Offset = "0x1708674", VA = "0x7BBBF08674", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}
		}

		// Token: 0x02002A73 RID: 10867
		[Token(Token = "0x2002A73")]
		private class xJ[DkSx : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EE0D RID: 60941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE0D")]
			[Address(RVA = "0x17086D4", Offset = "0x17086D4", VA = "0x7BBBF086D4")]
			public xJ[DkSx(Player Foy[QIo)
			{
			}

			// Token: 0x0600EE0E RID: 60942 RVA: 0x00043F08 File Offset: 0x00042108
			[Token(Token = "0x600EE0E")]
			[Address(RVA = "0x1708700", Offset = "0x1708700", VA = "0x7BBBF08700", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EE0F RID: 60943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE0F")]
			[Address(RVA = "0x1708708", Offset = "0x1708708", VA = "0x7BBBF08708", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}

			// Token: 0x0600EE10 RID: 60944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE10")]
			[Address(RVA = "0x1708794", Offset = "0x1708794", VA = "0x7BBBF08794", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EE11 RID: 60945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE11")]
			[Address(RVA = "0x1708820", Offset = "0x1708820", VA = "0x7BBBF08820", Slot = "7")]
			protected override void niswrhm(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EE12 RID: 60946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE12")]
			[Address(RVA = "0x1708824", Offset = "0x1708824", VA = "0x7BBBF08824", Slot = "8")]
			protected override void GIZJBXC(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EE13 RID: 60947 RVA: 0x00043F20 File Offset: 0x00042120
			[Token(Token = "0x600EE13")]
			[Address(RVA = "0x1708830", Offset = "0x1708830", VA = "0x7BBBF08830", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}

			// Token: 0x0600EE14 RID: 60948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE14")]
			[Address(RVA = "0x1708828", Offset = "0x1708828", VA = "0x7BBBF08828")]
			private void F\u0081vVx(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EE15 RID: 60949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE15")]
			[Address(RVA = "0x170882C", Offset = "0x170882C", VA = "0x7BBBF0882C")]
			private void erEEYj\u0081(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}
		}

		// Token: 0x02002A74 RID: 10868
		[Token(Token = "0x2002A74")]
		private class b|Cs{ax : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EE16 RID: 60950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE16")]
			[Address(RVA = "0x1706E20", Offset = "0x1706E20", VA = "0x7BBBF06E20")]
			public b|Cs{ax(Player Foy[QIo)
			{
			}

			// Token: 0x0600EE17 RID: 60951 RVA: 0x00043F38 File Offset: 0x00042138
			[Token(Token = "0x600EE17")]
			[Address(RVA = "0x1706E4C", Offset = "0x1706E4C", VA = "0x7BBBF06E4C", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EE18 RID: 60952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE18")]
			[Address(RVA = "0x1706E54", Offset = "0x1706E54", VA = "0x7BBBF06E54", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EE19 RID: 60953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE19")]
			[Address(RVA = "0x1707140", Offset = "0x1707140", VA = "0x7BBBF07140", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}

			// Token: 0x0600EE1A RID: 60954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE1A")]
			[Address(RVA = "0x17073C0", Offset = "0x17073C0", VA = "0x7BBBF073C0", Slot = "8")]
			protected override void GIZJBXC(Player.T[m vgLvdok, VCDxuoO ~p^tZpZ)
			{
			}

			// Token: 0x0600EE1B RID: 60955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE1B")]
			[Address(RVA = "0x17076A8", Offset = "0x17076A8", VA = "0x7BBBF076A8", Slot = "7")]
			protected override void niswrhm(Player.T[m JXT\u0081\u0080QL, VCDxuoO |Dc\u0080arn)
			{
			}

			// Token: 0x0600EE1C RID: 60956 RVA: 0x00043F50 File Offset: 0x00042150
			[Token(Token = "0x600EE1C")]
			[Address(RVA = "0x17078A4", Offset = "0x17078A4", VA = "0x7BBBF078A4", Slot = "9")]
			protected override bool Dsk(VCDxuoO |Dc\u0080arn)
			{
				return default(bool);
			}
		}

		// Token: 0x02002A75 RID: 10869
		[Token(Token = "0x2002A75")]
		private class MjOfJ~G : Player.yWKZ\u0081mf
		{
			// Token: 0x0600EE1D RID: 60957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE1D")]
			[Address(RVA = "0x170175C", Offset = "0x170175C", VA = "0x7BBBF0175C")]
			public MjOfJ~G(Player Foy[QIo)
			{
			}

			// Token: 0x0600EE1E RID: 60958 RVA: 0x00043F68 File Offset: 0x00042168
			[Token(Token = "0x600EE1E")]
			[Address(RVA = "0x1701788", Offset = "0x1701788", VA = "0x7BBBF01788", Slot = "4")]
			public override Player.T[m K}o^rf[()
			{
				return Player.T[m.Walking;
			}

			// Token: 0x0600EE1F RID: 60959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE1F")]
			[Address(RVA = "0x1701790", Offset = "0x1701790", VA = "0x7BBBF01790", Slot = "6")]
			protected override void LFX}oZP(Player.T[m vgLvdok)
			{
			}

			// Token: 0x0600EE20 RID: 60960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE20")]
			[Address(RVA = "0x1701AFC", Offset = "0x1701AFC", VA = "0x7BBBF01AFC", Slot = "5")]
			protected override void JylPuu}(Player.T[m JXT\u0081\u0080QL)
			{
			}
		}

		// Token: 0x02002A76 RID: 10870
		// (Invoke) Token: 0x0600EE22 RID: 60962
		[Token(Token = "0x2002A76")]
		public delegate void iX^^Yu|(Player KE`SW[H, ppbgrHy fcvMHQg, float ygiuRUe = 0f, float NnXj|Aw = 0f);

		// Token: 0x02002A77 RID: 10871
		// (Invoke) Token: 0x0600EE26 RID: 60966
		[Token(Token = "0x2002A77")]
		public delegate void \u007FRm~a\u0081[(Player KE`SW[H, Player.T[m ZXcwzqU, Player.T[m JXT\u0081\u0080QL, VCDxuoO {[FeQSs, VCDxuoO |Dc\u0080arn);

		// Token: 0x02002A78 RID: 10872
		// (Invoke) Token: 0x0600EE2A RID: 60970
		[Token(Token = "0x2002A78")]
		public delegate void QYId]Kn(Player KE`SW[H, Vector3 \u0081cWZx[U, Quaternion zDMdZ\u007FH);

		// Token: 0x02002A79 RID: 10873
		[Token(Token = "0x2002A79")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEF70", Offset = "0x10FEF70")]
		private sealed class xgja^fe : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600EE2D RID: 60973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2D")]
			[Address(RVA = "0x170884C", Offset = "0x170884C", VA = "0x7BBBF0884C")]
			[DebuggerHidden]
			public xgja^fe(int zV[Cm[\u0082)
			{
			}

			// Token: 0x0600EE2E RID: 60974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE2E")]
			[Address(RVA = "0x1708878", Offset = "0x1708878", VA = "0x7BBBF08878", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600EE2F RID: 60975 RVA: 0x00043F80 File Offset: 0x00042180
			[Token(Token = "0x600EE2F")]
			[Address(RVA = "0x170887C", Offset = "0x170887C", VA = "0x7BBBF0887C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170010DB RID: 4315
			// (get) Token: 0x0600EE30 RID: 60976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170010DB")]
			private object Current
			{
				[Token(Token = "0x600EE30")]
				[Address(RVA = "0x1708978", Offset = "0x1708978", VA = "0x7BBBF08978", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600EE31 RID: 60977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE31")]
			[Address(RVA = "0x1708980", Offset = "0x1708980", VA = "0x7BBBF08980", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170010DC RID: 4316
			// (get) Token: 0x0600EE32 RID: 60978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170010DC")]
			private object Current
			{
				[Token(Token = "0x600EE32")]
				[Address(RVA = "0x17089E8", Offset = "0x17089E8", VA = "0x7BBBF089E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040115C3 RID: 71107
			[Token(Token = "0x40115C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int zV[Cm[\u0082;

			// Token: 0x040115C4 RID: 71108
			[Token(Token = "0x40115C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object YYdxtU];

			// Token: 0x040115C5 RID: 71109
			[Token(Token = "0x40115C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Player poIzdvJ;
		}

		// Token: 0x02002A7A RID: 10874
		[Token(Token = "0x2002A7A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEF80", Offset = "0x10FEF80")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600EE34 RID: 60980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE34")]
			[Address(RVA = "0x16FF700", Offset = "0x16FF700", VA = "0x7BBBEFF700")]
			public <>c()
			{
			}

			// Token: 0x0600EE35 RID: 60981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE35")]
			[Address(RVA = "0x16FF708", Offset = "0x16FF708", VA = "0x7BBBEFF708")]
			internal void di\u0080xBil()
			{
			}

			// Token: 0x0600EE36 RID: 60982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE36")]
			[Address(RVA = "0x16FF82C", Offset = "0x16FF82C", VA = "0x7BBBEFF82C")]
			internal void EXBeVxE(float `bfaKtb)
			{
			}

			// Token: 0x040115C6 RID: 71110
			[Token(Token = "0x40115C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Player.<>c <>9;

			// Token: 0x040115C7 RID: 71111
			[Token(Token = "0x40115C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__733_0;

			// Token: 0x040115C8 RID: 71112
			[Token(Token = "0x40115C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<float> <>9__1036_0;
		}

		// Token: 0x02002A7B RID: 10875
		[Token(Token = "0x2002A7B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEF90", Offset = "0x10FEF90")]
		private sealed class [\u0082^yoDk
		{
			// Token: 0x0600EE37 RID: 60983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE37")]
			[Address(RVA = "0x1705F08", Offset = "0x1705F08", VA = "0x7BBBF05F08")]
			public [\u0082^yoDk()
			{
			}

			// Token: 0x040115C9 RID: 71113
			[Token(Token = "0x40115C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Player poIzdvJ;

			// Token: 0x040115CA RID: 71114
			[Token(Token = "0x40115CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint IbUpEoU;
		}

		// Token: 0x02002A7C RID: 10876
		[Token(Token = "0x2002A7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEFA0", Offset = "0x10FEFA0")]
		private sealed class zMPfMCW
		{
			// Token: 0x0600EE38 RID: 60984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE38")]
			[Address(RVA = "0x1708F50", Offset = "0x1708F50", VA = "0x7BBBF08F50")]
			public zMPfMCW()
			{
			}

			// Token: 0x0600EE39 RID: 60985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE39")]
			[Address(RVA = "0x1708F58", Offset = "0x1708F58", VA = "0x7BBBF08F58")]
			internal void pRlP\u0082oq()
			{
			}

			// Token: 0x040115CB RID: 71115
			[Token(Token = "0x40115CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LevelTeleportDoor UmPKRo};

			// Token: 0x040115CC RID: 71116
			[Token(Token = "0x40115CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Player.[\u0082^yoDk []IITCB;
		}

		// Token: 0x02002A7D RID: 10877
		[Token(Token = "0x2002A7D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEFB0", Offset = "0x10FEFB0")]
		private sealed class S^~lids : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600EE3A RID: 60986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE3A")]
			[Address(RVA = "0x1702808", Offset = "0x1702808", VA = "0x7BBBF02808")]
			[DebuggerHidden]
			public S^~lids(int zV[Cm[\u0082)
			{
			}

			// Token: 0x0600EE3B RID: 60987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE3B")]
			[Address(RVA = "0x1702834", Offset = "0x1702834", VA = "0x7BBBF02834", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600EE3C RID: 60988 RVA: 0x00043F98 File Offset: 0x00042198
			[Token(Token = "0x600EE3C")]
			[Address(RVA = "0x1702838", Offset = "0x1702838", VA = "0x7BBBF02838", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170010DD RID: 4317
			// (get) Token: 0x0600EE3D RID: 60989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170010DD")]
			private object Current
			{
				[Token(Token = "0x600EE3D")]
				[Address(RVA = "0x1702904", Offset = "0x1702904", VA = "0x7BBBF02904", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600EE3E RID: 60990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE3E")]
			[Address(RVA = "0x170290C", Offset = "0x170290C", VA = "0x7BBBF0290C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170010DE RID: 4318
			// (get) Token: 0x0600EE3F RID: 60991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170010DE")]
			private object Current
			{
				[Token(Token = "0x600EE3F")]
				[Address(RVA = "0x1702974", Offset = "0x1702974", VA = "0x7BBBF02974", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040115CD RID: 71117
			[Token(Token = "0x40115CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int zV[Cm[\u0082;

			// Token: 0x040115CE RID: 71118
			[Token(Token = "0x40115CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object YYdxtU];

			// Token: 0x040115CF RID: 71119
			[Token(Token = "0x40115CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Player poIzdvJ;
		}

		// Token: 0x02002A7E RID: 10878
		[Token(Token = "0x2002A7E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEFC0", Offset = "0x10FEFC0")]
		private sealed class pffvpcX : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600EE40 RID: 60992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE40")]
			[Address(RVA = "0x1708208", Offset = "0x1708208", VA = "0x7BBBF08208")]
			[DebuggerHidden]
			public pffvpcX(int zV[Cm[\u0082)
			{
			}

			// Token: 0x0600EE41 RID: 60993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE41")]
			[Address(RVA = "0x1708234", Offset = "0x1708234", VA = "0x7BBBF08234", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600EE42 RID: 60994 RVA: 0x00043FB0 File Offset: 0x000421B0
			[Token(Token = "0x600EE42")]
			[Address(RVA = "0x1708238", Offset = "0x1708238", VA = "0x7BBBF08238", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170010DF RID: 4319
			// (get) Token: 0x0600EE43 RID: 60995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170010DF")]
			private object Current
			{
				[Token(Token = "0x600EE43")]
				[Address(RVA = "0x1708550", Offset = "0x1708550", VA = "0x7BBBF08550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600EE44 RID: 60996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EE44")]
			[Address(RVA = "0x1708558", Offset = "0x1708558", VA = "0x7BBBF08558", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170010E0 RID: 4320
			// (get) Token: 0x0600EE45 RID: 60997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170010E0")]
			private object Current
			{
				[Token(Token = "0x600EE45")]
				[Address(RVA = "0x17085C0", Offset = "0x17085C0", VA = "0x7BBBF085C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040115D0 RID: 71120
			[Token(Token = "0x40115D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int zV[Cm[\u0082;

			// Token: 0x040115D1 RID: 71121
			[Token(Token = "0x40115D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object YYdxtU];

			// Token: 0x040115D2 RID: 71122
			[Token(Token = "0x40115D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Player poIzdvJ;
		}
	}
}
