using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001975 RID: 6517
	[Token(Token = "0x2001975")]
	internal class UIHUDTeamParachuteActionController : UIBaseController
	{
		// Token: 0x060084CC RID: 33996 RVA: 0x00024018 File Offset: 0x00022218
		[Token(Token = "0x60084CC")]
		[Address(RVA = "0x1D4F2DC", Offset = "0x1D4F2DC", VA = "0x7BBC54F2DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084CD")]
		[Address(RVA = "0x1D4F32C", Offset = "0x1D4F32C", VA = "0x7BBC54F32C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084CE")]
		[Address(RVA = "0x1D4F6AC", Offset = "0x1D4F6AC", VA = "0x7BBC54F6AC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084CF")]
		[Address(RVA = "0x1D4F834", Offset = "0x1D4F834", VA = "0x7BBC54F834")]
		private void ActionButtonDown()
		{
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D0")]
		[Address(RVA = "0x1D511F0", Offset = "0x1D511F0", VA = "0x7BBC5511F0")]
		public void OnModeChange(kd[\u0080AVO targetMode)
		{
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D1")]
		[Address(RVA = "0x1D51218", Offset = "0x1D51218", VA = "0x7BBC551218")]
		private void SwitchToFreeUI()
		{
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D2")]
		[Address(RVA = "0x1D51630", Offset = "0x1D51630", VA = "0x7BBC551630")]
		private void SwitchToFollowUI()
		{
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D3")]
		[Address(RVA = "0x1D51768", Offset = "0x1D51768", VA = "0x7BBC551768")]
		private void SwitchToLeaderUI()
		{
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D4")]
		[Address(RVA = "0x1D5194C", Offset = "0x1D5194C", VA = "0x7BBC55194C")]
		private void HideOrShowTransferBtn(params object[] data)
		{
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D5")]
		[Address(RVA = "0x1D4FA44", Offset = "0x1D4FA44", VA = "0x7BBC54FA44")]
		private void UpdateTransferPickupList()
		{
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D6")]
		[Address(RVA = "0x1D50028", Offset = "0x1D50028", VA = "0x7BBC550028")]
		private void RefreshLeaderPanelUI()
		{
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D7")]
		[Address(RVA = "0x1D51AB0", Offset = "0x1D51AB0", VA = "0x7BBC551AB0")]
		private void OnBtn1Click()
		{
		}

		// Token: 0x060084D8 RID: 34008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D8")]
		[Address(RVA = "0x1D51D30", Offset = "0x1D51D30", VA = "0x7BBC551D30")]
		private void OnBtn2Click()
		{
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084D9")]
		[Address(RVA = "0x1D51E30", Offset = "0x1D51E30", VA = "0x7BBC551E30")]
		private void OnBtn3Click()
		{
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60084DA")]
		[Address(RVA = "0x1D51C98", Offset = "0x1D51C98", VA = "0x7BBC551C98")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143394", Offset = "0x1143394")]
		private IEnumerator HideLeaderPanel(float seconds)
		{
			return null;
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084DB")]
		[Address(RVA = "0x1D51F5C", Offset = "0x1D51F5C", VA = "0x7BBC551F5C")]
		private void onBgBtnClick()
		{
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084DC")]
		[Address(RVA = "0x1D51BB0", Offset = "0x1D51BB0", VA = "0x7BBC551BB0")]
		private void RequestTransferLeader({QAb\u0082~u pid)
		{
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084DD")]
		[Address(RVA = "0x1D51FA0", Offset = "0x1D51FA0", VA = "0x7BBC551FA0")]
		public UIHUDTeamParachuteActionController()
		{
		}

		// Token: 0x040094C9 RID: 38089
		[Token(Token = "0x40094C9")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDTeamParachuteActionView m_View;

		// Token: 0x040094CA RID: 38090
		[Token(Token = "0x40094CA")]
		[FieldOffset(Offset = "0x60")]
		private kd[\u0080AVO m_CurMode;

		// Token: 0x040094CB RID: 38091
		[Token(Token = "0x40094CB")]
		[FieldOffset(Offset = "0x68")]
		private List<UIHUDTeamParachuteActionController.TransferOption> m_TransferPickList;

		// Token: 0x040094CC RID: 38092
		[Token(Token = "0x40094CC")]
		[FieldOffset(Offset = "0x70")]
		private K^u\u007F|WR m_TeamParachuteManager;

		// Token: 0x02001976 RID: 6518
		[Token(Token = "0x2001976")]
		private struct TransferOption
		{
			// Token: 0x060084DE RID: 34014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60084DE")]
			[Address(RVA = "0x11F0E18", Offset = "0x11F0E18", VA = "0x7BBB9F0E18")]
			public TransferOption({QAb\u0082~u pid, int teamidex)
			{
			}

			// Token: 0x040094CD RID: 38093
			[Token(Token = "0x40094CD")]
			[FieldOffset(Offset = "0x0")]
			public {QAb\u0082~u playerId;

			// Token: 0x040094CE RID: 38094
			[Token(Token = "0x40094CE")]
			[FieldOffset(Offset = "0x18")]
			public int teamIdex;
		}

		// Token: 0x02001977 RID: 6519
		[Token(Token = "0x2001977")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F65A4", Offset = "0x10F65A4")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x060084DF RID: 34015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60084DF")]
			[Address(RVA = "0x1D51A90", Offset = "0x1D51A90", VA = "0x7BBC551A90")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x060084E0 RID: 34016 RVA: 0x00024030 File Offset: 0x00022230
			[Token(Token = "0x60084E0")]
			[Address(RVA = "0x1D520EC", Offset = "0x1D520EC", VA = "0x7BBC5520EC")]
			internal bool <UpdateTransferPickupList>b__1(UIHUDTeamParachuteActionController.TransferOption a)
			{
				return default(bool);
			}

			// Token: 0x040094CF RID: 38095
			[Token(Token = "0x40094CF")]
			[FieldOffset(Offset = "0x10")]
			public Player p;
		}

		// Token: 0x02001978 RID: 6520
		[Token(Token = "0x2001978")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F65B4", Offset = "0x10F65B4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060084E2 RID: 34018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60084E2")]
			[Address(RVA = "0x1D52074", Offset = "0x1D52074", VA = "0x7BBC552074")]
			public <>c()
			{
			}

			// Token: 0x060084E3 RID: 34019 RVA: 0x00024048 File Offset: 0x00022248
			[Token(Token = "0x60084E3")]
			[Address(RVA = "0x1D5207C", Offset = "0x1D5207C", VA = "0x7BBC55207C")]
			internal int <UpdateTransferPickupList>b__14_0(Player a, Player b)
			{
				return 0;
			}

			// Token: 0x040094D0 RID: 38096
			[Token(Token = "0x40094D0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHUDTeamParachuteActionController.<>c <>9;

			// Token: 0x040094D1 RID: 38097
			[Token(Token = "0x40094D1")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Player> <>9__14_0;
		}

		// Token: 0x02001979 RID: 6521
		[Token(Token = "0x2001979")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F65C4", Offset = "0x10F65C4")]
		private sealed class <HideLeaderPanel>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060084E4 RID: 34020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60084E4")]
			[Address(RVA = "0x1D51F30", Offset = "0x1D51F30", VA = "0x7BBC551F30")]
			[DebuggerHidden]
			public <HideLeaderPanel>d__19(int <>1__state)
			{
			}

			// Token: 0x060084E5 RID: 34021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60084E5")]
			[Address(RVA = "0x1D521C4", Offset = "0x1D521C4", VA = "0x7BBC5521C4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060084E6 RID: 34022 RVA: 0x00024060 File Offset: 0x00022260
			[Token(Token = "0x60084E6")]
			[Address(RVA = "0x1D521C8", Offset = "0x1D521C8", VA = "0x7BBC5521C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x060084E7 RID: 34023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009AF")]
			private object Current
			{
				[Token(Token = "0x60084E7")]
				[Address(RVA = "0x1D522A8", Offset = "0x1D522A8", VA = "0x7BBC5522A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060084E8 RID: 34024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60084E8")]
			[Address(RVA = "0x1D522B0", Offset = "0x1D522B0", VA = "0x7BBC5522B0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x060084E9 RID: 34025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009B0")]
			private object Current
			{
				[Token(Token = "0x60084E9")]
				[Address(RVA = "0x1D52318", Offset = "0x1D52318", VA = "0x7BBC552318", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040094D2 RID: 38098
			[Token(Token = "0x40094D2")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040094D3 RID: 38099
			[Token(Token = "0x40094D3")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040094D4 RID: 38100
			[Token(Token = "0x40094D4")]
			[FieldOffset(Offset = "0x20")]
			public float seconds;

			// Token: 0x040094D5 RID: 38101
			[Token(Token = "0x40094D5")]
			[FieldOffset(Offset = "0x28")]
			public UIHUDTeamParachuteActionController <>4__this;
		}
	}
}
