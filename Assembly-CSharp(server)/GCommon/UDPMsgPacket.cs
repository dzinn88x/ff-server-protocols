using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB6 RID: 4022
	[Token(Token = "0x2000FB6")]
	public class UDPMsgPacket : ObjectPoolCallbackBase
	{
		// Token: 0x06003A93 RID: 14995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A93")]
		[Address(RVA = "0x2018A98", Offset = "0x2018A98", VA = "0x7BBC818A98")]
		public static UDPMsgPacket Get()
		{
			return null;
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A94")]
		[Address(RVA = "0x2018B1C", Offset = "0x2018B1C", VA = "0x7BBC818B1C")]
		public static void Put(UDPMsgPacket p)
		{
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A95")]
		[Address(RVA = "0x2018BE4", Offset = "0x2018BE4", VA = "0x7BBC818BE4")]
		public static void ClearCache()
		{
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A96")]
		[Address(RVA = "0x2018C64", Offset = "0x2018C64", VA = "0x7BBC818C64", Slot = "7")]
		public override void OnAllocated()
		{
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x00012270 File Offset: 0x00010470
		[Token(Token = "0x6003A97")]
		[Address(RVA = "0x2018CA0", Offset = "0x2018CA0", VA = "0x7BBC818CA0")]
		public uint Unserialize(UDPSession session, BinaryReader reader, int availableLength)
		{
			return 0U;
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x00012288 File Offset: 0x00010488
		[Token(Token = "0x6003A98")]
		[Address(RVA = "0x20192A0", Offset = "0x20192A0", VA = "0x7BBC8192A0")]
		public uint Serialize(UDPSession session, BinaryWriter writer)
		{
			return 0U;
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x6003A99")]
		[Address(RVA = "0x20190B4", Offset = "0x20190B4", VA = "0x7BBC8190B4")]
		public static bool IsReliable(uint cmd, byte sendOption)
		{
			return default(bool);
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x000122B8 File Offset: 0x000104B8
		[Token(Token = "0x6003A9A")]
		[Address(RVA = "0x20196FC", Offset = "0x20196FC", VA = "0x7BBC8196FC")]
		public bool IsReliable()
		{
			return default(bool);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x000122D0 File Offset: 0x000104D0
		[Token(Token = "0x6003A9B")]
		[Address(RVA = "0x2019790", Offset = "0x2019790", VA = "0x7BBC819790")]
		public bool IsVarPacket()
		{
			return default(bool);
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x20197A8", Offset = "0x20197A8", VA = "0x7BBC8197A8")]
		public UDPMsgPacket()
		{
		}

		// Token: 0x04004C24 RID: 19492
		[Token(Token = "0x4004C24")]
		[FieldOffset(Offset = "0x0")]
		private static SyncedObjectPool<UDPMsgPacket> m_MsgPacketPool;

		// Token: 0x04004C25 RID: 19493
		[Token(Token = "0x4004C25")]
		public const uint UDPMESSAGE_HEADER_MINI_SIZE = 5U;

		// Token: 0x04004C26 RID: 19494
		[Token(Token = "0x4004C26")]
		public const uint UDPMESSAGE_HEADER_RELIABLE_SIZE = 12U;

		// Token: 0x04004C27 RID: 19495
		[Token(Token = "0x4004C27")]
		public const uint UDPMESSAGE_HEADER_NONRELIABLE_SIZE = 8U;

		// Token: 0x04004C28 RID: 19496
		[Token(Token = "0x4004C28")]
		public const byte UDPMESSAGE_MSGKEY = 108;

		// Token: 0x04004C29 RID: 19497
		[Token(Token = "0x4004C29")]
		public const byte UDPMESSAGE_SENDOPTION_NONE = 0;

		// Token: 0x04004C2A RID: 19498
		[Token(Token = "0x4004C2A")]
		public const byte UDPMESSAGE_SENDOPTION_HELLO = 1;

		// Token: 0x04004C2B RID: 19499
		[Token(Token = "0x4004C2B")]
		public const byte UDPMESSAGE_SENDOPTION_RELIABLE = 2;

		// Token: 0x04004C2C RID: 19500
		[Token(Token = "0x4004C2C")]
		public const byte UDPMESSAGE_SENDOPTION_BYEBYE = 3;

		// Token: 0x04004C2D RID: 19501
		[Token(Token = "0x4004C2D")]
		public const byte UDPMESSAGE_SENDOPTION_VAR = 4;

		// Token: 0x04004C2E RID: 19502
		[Token(Token = "0x4004C2E")]
		public const byte UDPMESSAGE_SENDOPTION_VAR_RELIABLE = 5;

		// Token: 0x04004C2F RID: 19503
		[Token(Token = "0x4004C2F")]
		public const uint UDPMESSAGE_FLAG_ENCRYPTION = 1U;

		// Token: 0x04004C30 RID: 19504
		[Token(Token = "0x4004C30")]
		public const uint UDPMESSAGE_FLAG_ZIP = 2U;

		// Token: 0x04004C31 RID: 19505
		[Token(Token = "0x4004C31")]
		[FieldOffset(Offset = "0x11")]
		public byte MsgKey;

		// Token: 0x04004C32 RID: 19506
		[Token(Token = "0x4004C32")]
		[FieldOffset(Offset = "0x12")]
		public byte CRC7;

		// Token: 0x04004C33 RID: 19507
		[Token(Token = "0x4004C33")]
		[FieldOffset(Offset = "0x13")]
		public byte SendOption;

		// Token: 0x04004C34 RID: 19508
		[Token(Token = "0x4004C34")]
		[FieldOffset(Offset = "0x14")]
		public ushort Cmd;

		// Token: 0x04004C35 RID: 19509
		[Token(Token = "0x4004C35")]
		[FieldOffset(Offset = "0x16")]
		public ushort SequenceID;

		// Token: 0x04004C36 RID: 19510
		[Token(Token = "0x4004C36")]
		[FieldOffset(Offset = "0x18")]
		public ushort OrderID;

		// Token: 0x04004C37 RID: 19511
		[Token(Token = "0x4004C37")]
		[FieldOffset(Offset = "0x1A")]
		public byte Flags;

		// Token: 0x04004C38 RID: 19512
		[Token(Token = "0x4004C38")]
		[FieldOffset(Offset = "0x1C")]
		public ushort Length;

		// Token: 0x04004C39 RID: 19513
		[Token(Token = "0x4004C39")]
		[FieldOffset(Offset = "0x20")]
		public byte[] Data;

		// Token: 0x04004C3A RID: 19514
		[Token(Token = "0x4004C3A")]
		[FieldOffset(Offset = "0x28")]
		public uint TrackingID;
	}
}
