using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001DA2 RID: 7586
	[Token(Token = "0x2001DA2")]
	public class UIModelBroadcast : UIBaseModel
	{
		// Token: 0x0600A5E6 RID: 42470 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
		[Token(Token = "0x600A5E6")]
		[Address(RVA = "0x22DF94C", Offset = "0x22DF94C", VA = "0x7BBCADF94C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x0600A5E7 RID: 42471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE8")]
		public List<BroadcastMessage> BroadcastDataList
		{
			[Token(Token = "0x600A5E7")]
			[Address(RVA = "0x22DF954", Offset = "0x22DF954", VA = "0x7BBCADF954")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE9")]
		public List<ScrollMarqueeDesc> ScrollMarDataList
		{
			[Token(Token = "0x600A5E8")]
			[Address(RVA = "0x22DF95C", Offset = "0x22DF95C", VA = "0x7BBCADF95C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x0600A5E9 RID: 42473 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
		// (set) Token: 0x0600A5EA RID: 42474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEA")]
		public bool SilenceSwitch
		{
			[Token(Token = "0x600A5E9")]
			[Address(RVA = "0x22DFC24", Offset = "0x22DFC24", VA = "0x7BBCADFC24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C0C", Offset = "0x1145C0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A5EA")]
			[Address(RVA = "0x22DFC2C", Offset = "0x22DFC2C", VA = "0x7BBCADFC2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C1C", Offset = "0x1145C1C")]
			private set
			{
			}
		}

		// Token: 0x0600A5EB RID: 42475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EB")]
		[Address(RVA = "0x22DFC38", Offset = "0x22DFC38", VA = "0x7BBCADFC38", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A5EC RID: 42476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EC")]
		[Address(RVA = "0x22DFD04", Offset = "0x22DFD04", VA = "0x7BBCADFD04", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A5ED RID: 42477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5ED")]
		[Address(RVA = "0x22DFDA4", Offset = "0x22DFDA4", VA = "0x7BBCADFDA4")]
		public string MakeRollMessage(BroadcastMessage brMsg)
		{
			return null;
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EE")]
		[Address(RVA = "0x22E0184", Offset = "0x22E0184", VA = "0x7BBCAE0184")]
		private void OnLoginGetBroadCast()
		{
		}

		// Token: 0x0600A5EF RID: 42479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EF")]
		[Address(RVA = "0x22E01F0", Offset = "0x22E01F0", VA = "0x7BBCAE01F0")]
		public void LoginGetBroadcast(bool preload = false)
		{
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5F0")]
		[Address(RVA = "0x22E0504", Offset = "0x22E0504", VA = "0x7BBCAE0504")]
		public void RequestBroadcastDataOnly()
		{
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5F1")]
		[Address(RVA = "0x22E0724", Offset = "0x22E0724", VA = "0x7BBCAE0724")]
		private void ProcessMarqueeRes(CSScrollMarqueeRes scroll_res)
		{
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5F2")]
		[Address(RVA = "0x22E09B4", Offset = "0x22E09B4", VA = "0x7BBCAE09B4")]
		public void ProcessFriendsOnlineNotify(string name, uint intimacy)
		{
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5F3")]
		[Address(RVA = "0x22E0BB4", Offset = "0x22E0BB4", VA = "0x7BBCAE0BB4")]
		public void ProcessLoudSpeaker(RollNoticeData data)
		{
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5F4")]
		[Address(RVA = "0x22E0C80", Offset = "0x22E0C80", VA = "0x7BBCAE0C80")]
		private void ProcessBroadcastRes(CSGetBroadcastListRes broadcastMsgRes)
		{
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5F5")]
		[Address(RVA = "0x22E0EA4", Offset = "0x22E0EA4", VA = "0x7BBCAE0EA4")]
		public UIModelBroadcast()
		{
		}

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5F6")]
		[Address(RVA = "0x22E0F5C", Offset = "0x22E0F5C", VA = "0x7BBCAE0F5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C2C", Offset = "0x1145C2C")]
		private void <RequestBroadcastDataOnly>b__20_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AB94 RID: 43924
		[Token(Token = "0x400AB94")]
		[FieldOffset(Offset = "0x18")]
		private List<BroadcastMessage> m_BroadcastMsgList;

		// Token: 0x0400AB95 RID: 43925
		[Token(Token = "0x400AB95")]
		[FieldOffset(Offset = "0x20")]
		private List<ScrollMarqueeDesc> m_ScrollMarDataList;

		// Token: 0x0400AB96 RID: 43926
		[Token(Token = "0x400AB96")]
		public const uint PropID_BroadcastRetOK = 2U;

		// Token: 0x0400AB97 RID: 43927
		[Token(Token = "0x400AB97")]
		public const uint PropID_FriendsOnlineNotify = 4U;

		// Token: 0x0400AB98 RID: 43928
		[Token(Token = "0x400AB98")]
		public const uint PropID_LoudSpeakerNotify = 8U;

		// Token: 0x0400AB99 RID: 43929
		[Token(Token = "0x400AB99")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE8C", Offset = "0x112FE8C")]
		private bool <SilenceSwitch>k__BackingField;

		// Token: 0x0400AB9A RID: 43930
		[Token(Token = "0x400AB9A")]
		[FieldOffset(Offset = "0x29")]
		private bool m_PreloadBroadcast;

		// Token: 0x02001DA3 RID: 7587
		[Token(Token = "0x2001DA3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF74", Offset = "0x10FBF74")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x0600A5F7 RID: 42487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5F7")]
			[Address(RVA = "0x22E04FC", Offset = "0x22E04FC", VA = "0x7BBCAE04FC")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x0600A5F8 RID: 42488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5F8")]
			[Address(RVA = "0x22E1284", Offset = "0x22E1284", VA = "0x7BBCAE1284")]
			internal void <LoginGetBroadcast>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AB9B RID: 43931
			[Token(Token = "0x400AB9B")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBroadcast <>4__this;

			// Token: 0x0400AB9C RID: 43932
			[Token(Token = "0x400AB9C")]
			[FieldOffset(Offset = "0x18")]
			public bool preload;
		}

		// Token: 0x02001DA4 RID: 7588
		[Token(Token = "0x2001DA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF84", Offset = "0x10FBF84")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A5FA RID: 42490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5FA")]
			[Address(RVA = "0x22E1234", Offset = "0x22E1234", VA = "0x7BBCAE1234")]
			public <>c()
			{
			}

			// Token: 0x0600A5FB RID: 42491 RVA: 0x0002C5E0 File Offset: 0x0002A7E0
			[Token(Token = "0x600A5FB")]
			[Address(RVA = "0x22E123C", Offset = "0x22E123C", VA = "0x7BBCAE123C")]
			internal int <ProcessMarqueeRes>b__21_0(ScrollMarqueeDesc a, ScrollMarqueeDesc b)
			{
				return 0;
			}

			// Token: 0x0400AB9D RID: 43933
			[Token(Token = "0x400AB9D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelBroadcast.<>c <>9;

			// Token: 0x0400AB9E RID: 43934
			[Token(Token = "0x400AB9E")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ScrollMarqueeDesc> <>9__21_0;
		}

		// Token: 0x02001DA5 RID: 7589
		[Token(Token = "0x2001DA5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF94", Offset = "0x10FBF94")]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x0600A5FC RID: 42492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5FC")]
			[Address(RVA = "0x22E0E9C", Offset = "0x22E0E9C", VA = "0x7BBCAE0E9C")]
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x0600A5FD RID: 42493 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
			[Token(Token = "0x600A5FD")]
			[Address(RVA = "0x22E15A8", Offset = "0x22E15A8", VA = "0x7BBCAE15A8")]
			internal int <ProcessBroadcastRes>b__0(BroadcastMessage a, BroadcastMessage b)
			{
				return 0;
			}

			// Token: 0x0400AB9F RID: 43935
			[Token(Token = "0x400AB9F")]
			[FieldOffset(Offset = "0x10")]
			public string myName;
		}
	}
}
