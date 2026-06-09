using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019A7 RID: 6567
	[Token(Token = "0x20019A7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6C9C", Offset = "0x10F6C9C")]
	public class UIHudWereWolvesSpeakerController : UIBaseController, IEasyList
	{
		// Token: 0x0600867B RID: 34427 RVA: 0x00024648 File Offset: 0x00022848
		[Token(Token = "0x600867B")]
		[Address(RVA = "0x1D14D84", Offset = "0x1D14D84", VA = "0x7BBC514D84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600867C")]
		[Address(RVA = "0x1D14DD4", Offset = "0x1D14DD4", VA = "0x7BBC514DD4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600867D")]
		[Address(RVA = "0x1D14FF8", Offset = "0x1D14FF8", VA = "0x7BBC514FF8")]
		public void SetData(UIHudWereWolvesVoteController parent)
		{
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x00024660 File Offset: 0x00022860
		[Token(Token = "0x600867E")]
		[Address(RVA = "0x1D154F4", Offset = "0x1D154F4", VA = "0x7BBC5154F4")]
		private int Cmp(zCUI\u0081}O infoA, zCUI\u0081}O infoB)
		{
			return 0;
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600867F")]
		[Address(RVA = "0x1D15558", Offset = "0x1D15558", VA = "0x7BBC515558", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008680 RID: 34432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008680")]
		[Address(RVA = "0x1D15614", Offset = "0x1D15614", VA = "0x7BBC515614", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008681")]
		[Address(RVA = "0x1D15644", Offset = "0x1D15644", VA = "0x7BBC515644")]
		private void OnAllClick()
		{
		}

		// Token: 0x06008682 RID: 34434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008682")]
		[Address(RVA = "0x1D15978", Offset = "0x1D15978", VA = "0x7BBC515978")]
		private void OnBgClick()
		{
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008683")]
		[Address(RVA = "0x1D15A48", Offset = "0x1D15A48", VA = "0x7BBC515A48")]
		public UIHudWereWolvesSpeakerController()
		{
		}

		// Token: 0x0400958B RID: 38283
		[Token(Token = "0x400958B")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesVoteSpeakerView m_View;

		// Token: 0x0400958C RID: 38284
		[Token(Token = "0x400958C")]
		[FieldOffset(Offset = "0x60")]
		private UIHudWereWolvesVoteController m_parent;

		// Token: 0x0400958D RID: 38285
		[Token(Token = "0x400958D")]
		[FieldOffset(Offset = "0x68")]
		private List<{QAb\u0082~u> m_PlayerList;

		// Token: 0x020019A8 RID: 6568
		[Token(Token = "0x20019A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6CD4", Offset = "0x10F6CD4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008685 RID: 34437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008685")]
			[Address(RVA = "0x1D15B1C", Offset = "0x1D15B1C", VA = "0x7BBC515B1C")]
			public <>c()
			{
			}

			// Token: 0x06008686 RID: 34438 RVA: 0x00024678 File Offset: 0x00022878
			[Token(Token = "0x6008686")]
			[Address(RVA = "0x1D15B24", Offset = "0x1D15B24", VA = "0x7BBC515B24")]
			internal bool <SetData>b__5_0(zCUI\u0081}O voteInfo)
			{
				return default(bool);
			}

			// Token: 0x0400958E RID: 38286
			[Token(Token = "0x400958E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudWereWolvesSpeakerController.<>c <>9;

			// Token: 0x0400958F RID: 38287
			[Token(Token = "0x400958F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<zCUI\u0081}O, bool> <>9__5_0;
		}
	}
}
