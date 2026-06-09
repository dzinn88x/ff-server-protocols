using System;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001DE4 RID: 7652
	[Token(Token = "0x2001DE4")]
	public class MessageInfo
	{
		// Token: 0x0600A739 RID: 42809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A739")]
		[Address(RVA = "0x1A5CCD0", Offset = "0x1A5CCD0", VA = "0x7BBC25CCD0")]
		public MessageInfo()
		{
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A73A")]
		[Address(RVA = "0x1A5CCE0", Offset = "0x1A5CCE0", VA = "0x7BBC25CCE0")]
		public MessageInfo(TextMsgReq req)
		{
		}

		// Token: 0x0600A73B RID: 42811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A73B")]
		[Address(RVA = "0x1A5CF48", Offset = "0x1A5CF48", VA = "0x7BBC25CF48")]
		public void UpdateProfileInfo()
		{
		}

		// Token: 0x0600A73C RID: 42812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A73C")]
		[Address(RVA = "0x1A5D088", Offset = "0x1A5D088", VA = "0x7BBC25D088")]
		public string GetSenderName()
		{
			return null;
		}

		// Token: 0x0600A73D RID: 42813 RVA: 0x0002D0A8 File Offset: 0x0002B2A8
		[Token(Token = "0x600A73D")]
		[Address(RVA = "0x1A5D1D0", Offset = "0x1A5D1D0", VA = "0x7BBC25D1D0")]
		public bool IsFastClanRecruit()
		{
			return default(bool);
		}

		// Token: 0x0600A73E RID: 42814 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		[Token(Token = "0x600A73E")]
		[Address(RVA = "0x1A5D328", Offset = "0x1A5D328", VA = "0x7BBC25D328")]
		public bool IsFastGroupRecruit()
		{
			return default(bool);
		}

		// Token: 0x0600A73F RID: 42815 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		[Token(Token = "0x600A73F")]
		[Address(RVA = "0x1A5D480", Offset = "0x1A5D480", VA = "0x7BBC25D480")]
		public bool IsFastChampionshipTeamRecruit()
		{
			return default(bool);
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
		[Token(Token = "0x600A740")]
		[Address(RVA = "0x1A5D5D8", Offset = "0x1A5D5D8", VA = "0x7BBC25D5D8")]
		public bool CheckContentHasFlag(string key)
		{
			return default(bool);
		}

		// Token: 0x0400ACDC RID: 44252
		[Token(Token = "0x400ACDC")]
		[FieldOffset(Offset = "0x10")]
		public EChannel.ChannelType RecvType;

		// Token: 0x0400ACDD RID: 44253
		[Token(Token = "0x400ACDD")]
		[FieldOffset(Offset = "0x18")]
		public ulong RecvID;

		// Token: 0x0400ACDE RID: 44254
		[Token(Token = "0x400ACDE")]
		[FieldOffset(Offset = "0x20")]
		public ulong SenderID;

		// Token: 0x0400ACDF RID: 44255
		[Token(Token = "0x400ACDF")]
		[FieldOffset(Offset = "0x28")]
		public BaseProfileInfo SenderInfo;

		// Token: 0x0400ACE0 RID: 44256
		[Token(Token = "0x400ACE0")]
		[FieldOffset(Offset = "0x30")]
		public EChannel.MsgType MessageType;

		// Token: 0x0400ACE1 RID: 44257
		[Token(Token = "0x400ACE1")]
		[FieldOffset(Offset = "0x38")]
		public string MessageContent;

		// Token: 0x0400ACE2 RID: 44258
		[Token(Token = "0x400ACE2")]
		[FieldOffset(Offset = "0x40")]
		public string ExtraInfo;

		// Token: 0x0400ACE3 RID: 44259
		[Token(Token = "0x400ACE3")]
		[FieldOffset(Offset = "0x48")]
		public ulong SendTimeStamp;

		// Token: 0x0400ACE4 RID: 44260
		[Token(Token = "0x400ACE4")]
		[FieldOffset(Offset = "0x50")]
		public EChatMessageSendState SendState;

		// Token: 0x0400ACE5 RID: 44261
		[Token(Token = "0x400ACE5")]
		[FieldOffset(Offset = "0x58")]
		public ulong GroupId;

		// Token: 0x0400ACE6 RID: 44262
		[Token(Token = "0x400ACE6")]
		[FieldOffset(Offset = "0x60")]
		public EChatTipsType ChatTipsType;

		// Token: 0x0400ACE7 RID: 44263
		[Token(Token = "0x400ACE7")]
		[FieldOffset(Offset = "0x64")]
		public bool Reported;
	}
}
