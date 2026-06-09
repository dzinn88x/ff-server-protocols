using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020A1 RID: 8353
	[Token(Token = "0x20020A1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDC74", Offset = "0x10FDC74")]
	public class UIHudIntroCutsceneController : UIBaseController
	{
		// Token: 0x0600BBE9 RID: 48105 RVA: 0x00035268 File Offset: 0x00033468
		[Token(Token = "0x600BBE9")]
		[Address(RVA = "0x198C948", Offset = "0x198C948", VA = "0x7BBC18C948")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BBEA RID: 48106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBEA")]
		[Address(RVA = "0x198C998", Offset = "0x198C998", VA = "0x7BBC18C998", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BBEB RID: 48107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBEB")]
		[Address(RVA = "0x198DCB4", Offset = "0x198DCB4", VA = "0x7BBC18DCB4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600BBEC RID: 48108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBEC")]
		[Address(RVA = "0x198CB6C", Offset = "0x198CB6C", VA = "0x7BBC18CB6C")]
		private void PlayIntroCutscene()
		{
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBED")]
		[Address(RVA = "0x198DCF0", Offset = "0x198DCF0", VA = "0x7BBC18DCF0")]
		private void CheckAvatarFinishAndPlayIntro(Transform introShowPos)
		{
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBEE")]
		[Address(RVA = "0x198E964", Offset = "0x198E964", VA = "0x7BBC18E964")]
		private void ShowNameUI()
		{
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBEF")]
		[Address(RVA = "0x198F320", Offset = "0x198F320", VA = "0x7BBC18F320")]
		public UIHudIntroCutsceneController()
		{
		}

		// Token: 0x0600BBF1 RID: 48113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBF1")]
		[Address(RVA = "0x198F40C", Offset = "0x198F40C", VA = "0x7BBC18F40C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147D64", Offset = "0x1147D64")]
		private void <CheckAvatarFinishAndPlayIntro>b__10_0()
		{
		}

		// Token: 0x0400BC9D RID: 48285
		[Token(Token = "0x400BC9D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudIntroCutsceneView m_View;

		// Token: 0x0400BC9E RID: 48286
		[Token(Token = "0x400BC9E")]
		[FieldOffset(Offset = "0x60")]
		private List<UILabel> m_TeammateLabelList;

		// Token: 0x0400BC9F RID: 48287
		[Token(Token = "0x400BC9F")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<uint, UIMaleAvatar> m_AvatarDic;

		// Token: 0x0400BCA0 RID: 48288
		[Token(Token = "0x400BCA0")]
		[FieldOffset(Offset = "0x70")]
		private int m_FinishInitAvatarCount;

		// Token: 0x0400BCA1 RID: 48289
		[Token(Token = "0x400BCA1")]
		[FieldOffset(Offset = "0x78")]
		private GameObject team_format_go;

		// Token: 0x0400BCA2 RID: 48290
		[Token(Token = "0x400BCA2")]
		[FieldOffset(Offset = "0x0")]
		private static uint DEFAULT_SHOW_WEAPON_ID;

		// Token: 0x020020A2 RID: 8354
		[Token(Token = "0x20020A2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDCAC", Offset = "0x10FDCAC")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600BBF2 RID: 48114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BBF2")]
			[Address(RVA = "0x198DCE8", Offset = "0x198DCE8", VA = "0x7BBC18DCE8")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600BBF3 RID: 48115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BBF3")]
			[Address(RVA = "0x198F610", Offset = "0x198F610", VA = "0x7BBC18F610")]
			internal void <PlayIntroCutscene>b__0(UIStatedAvatar s)
			{
			}

			// Token: 0x0400BCA3 RID: 48291
			[Token(Token = "0x400BCA3")]
			[FieldOffset(Offset = "0x10")]
			public UIHudIntroCutsceneController <>4__this;

			// Token: 0x0400BCA4 RID: 48292
			[Token(Token = "0x400BCA4")]
			[FieldOffset(Offset = "0x18")]
			public Transform introShowPos;

			// Token: 0x0400BCA5 RID: 48293
			[Token(Token = "0x400BCA5")]
			[FieldOffset(Offset = "0x20")]
			public Action<UIStatedAvatar> <>9__0;
		}
	}
}
