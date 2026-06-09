using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001353 RID: 4947
	[Token(Token = "0x2001353")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB1F0", Offset = "0x10EB1F0")]
	public class ActivityPreloginDescription : ActivityAwardDescription
	{
		// Token: 0x06004EA6 RID: 20134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x154ADCC", Offset = "0x154ADCC", VA = "0x7BBBD4ADCC", Slot = "28")]
		protected override void SetOperateButtonUI()
		{
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x154B3EC", Offset = "0x154B3EC", VA = "0x7BBBD4B3EC", Slot = "29")]
		protected override void OnOperate()
		{
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x154B6A8", Offset = "0x154B6A8", VA = "0x7BBBD4B6A8")]
		public ActivityPreloginDescription()
		{
		}

		// Token: 0x040075D0 RID: 30160
		[Token(Token = "0x40075D0")]
		[FieldOffset(Offset = "0xC8")]
		private ActivityPreloginDescription.OperateStatus m_OperateStatus;

		// Token: 0x02001354 RID: 4948
		[Token(Token = "0x2001354")]
		private enum OperateStatus
		{
			// Token: 0x040075D2 RID: 30162
			[Token(Token = "0x40075D2")]
			None,
			// Token: 0x040075D3 RID: 30163
			[Token(Token = "0x40075D3")]
			Book,
			// Token: 0x040075D4 RID: 30164
			[Token(Token = "0x40075D4")]
			Booked,
			// Token: 0x040075D5 RID: 30165
			[Token(Token = "0x40075D5")]
			Available,
			// Token: 0x040075D6 RID: 30166
			[Token(Token = "0x40075D6")]
			Received
		}

		// Token: 0x02001355 RID: 4949
		[Token(Token = "0x2001355")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB228", Offset = "0x10EB228")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004EAA RID: 20138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EAA")]
			[Address(RVA = "0x154B714", Offset = "0x154B714", VA = "0x7BBBD4B714")]
			public <>c()
			{
			}

			// Token: 0x06004EAB RID: 20139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EAB")]
			[Address(RVA = "0x154B71C", Offset = "0x154B71C", VA = "0x7BBBD4B71C")]
			internal void <OnOperate>b__3_0(HttpErrorCode errCode, object obj)
			{
			}

			// Token: 0x040075D7 RID: 30167
			[Token(Token = "0x40075D7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ActivityPreloginDescription.<>c <>9;

			// Token: 0x040075D8 RID: 30168
			[Token(Token = "0x40075D8")]
			[FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__3_0;
		}
	}
}
