using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB9 RID: 4025
	[Token(Token = "0x2000FB9")]
	internal class UDPReliableTracking
	{
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x170006E9")]
		public bool NeedFlushForLongDeactiveTime
		{
			[Token(Token = "0x6003AA0")]
			[Address(RVA = "0x2019984", Offset = "0x2019984", VA = "0x7BBC819984")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA1")]
		[Address(RVA = "0x201998C", Offset = "0x201998C", VA = "0x7BBC81998C")]
		public UDPReliableTracking()
		{
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x6003AA2")]
		[Address(RVA = "0x2019A78", Offset = "0x2019A78", VA = "0x7BBC819A78")]
		public bool Update(ref List<UDPMsgPacket> packetToResend)
		{
			return default(bool);
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x6003AA3")]
		[Address(RVA = "0x201A708", Offset = "0x201A708", VA = "0x7BBC81A708")]
		private bool CheckAck(ushort seq, ushort ack, uint ackBits)
		{
			return default(bool);
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x201A7CC", Offset = "0x201A7CC", VA = "0x7BBC81A7CC")]
		public void HandleAck(ushort ack, uint ackBits)
		{
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA5")]
		[Address(RVA = "0x201AC94", Offset = "0x201AC94", VA = "0x7BBC81AC94")]
		public void AckSent(ushort sequenceID)
		{
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x6003AA6")]
		[Address(RVA = "0x201AF2C", Offset = "0x201AF2C", VA = "0x7BBC81AF2C")]
		public UDPReliableTracking.RECVRET PacketRecv(UDPMsgPacket packet)
		{
			return UDPReliableTracking.RECVRET.ENQUEUE;
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA7")]
		[Address(RVA = "0x201B0F4", Offset = "0x201B0F4", VA = "0x7BBC81B0F4")]
		public void ApplyReliableInfo(UDPMsgPacket packet)
		{
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x201A788", Offset = "0x201A788", VA = "0x7BBC81A788")]
		private int bitIndexForSequence(ushort seq, ushort ack)
		{
			return 0;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x6003AA9")]
		[Address(RVA = "0x201A7A4", Offset = "0x201A7A4", VA = "0x7BBC81A7A4")]
		private bool checkAckBits(uint ackBits, int bitIndex)
		{
			return default(bool);
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x6003AAA")]
		[Address(RVA = "0x201B458", Offset = "0x201B458", VA = "0x7BBC81B458")]
		private uint addAckBits(uint ackBits, int bitIndex)
		{
			return 0U;
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x00012390 File Offset: 0x00010590
		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x201B478", Offset = "0x201B478", VA = "0x7BBC81B478")]
		public uint GenAckBits(ushort ack)
		{
			return 0U;
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x201B6DC", Offset = "0x201B6DC", VA = "0x7BBC81B6DC")]
		public void UpdateActiveTime(double last, double current)
		{
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x201A600", Offset = "0x201A600", VA = "0x7BBC81A600")]
		public static void SortByTrackingID(LinkedList<UDPMsgPacketTrackingData> list)
		{
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAE")]
		private static void Sort<T>(LinkedListNode<T> head, LinkedListNode<T> tail, IComparer<T> comparer)
		{
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAF")]
		private static void Swap<T>(LinkedListNode<T> a, LinkedListNode<T> b)
		{
		}

		// Token: 0x04004C42 RID: 19522
		[Token(Token = "0x4004C42")]
		public const ushort MAX_SEQUENCE_ID = 65535;

		// Token: 0x04004C43 RID: 19523
		[Token(Token = "0x4004C43")]
		public const ushort MAX_ORDER_ID = 65535;

		// Token: 0x04004C44 RID: 19524
		[Token(Token = "0x4004C44")]
		[FieldOffset(Offset = "0x10")]
		private ushort m_LocalSequenceID;

		// Token: 0x04004C45 RID: 19525
		[Token(Token = "0x4004C45")]
		[FieldOffset(Offset = "0x12")]
		private ushort m_LocalOrderID;

		// Token: 0x04004C46 RID: 19526
		[Token(Token = "0x4004C46")]
		[FieldOffset(Offset = "0x14")]
		private ushort m_RequiredOrderID;

		// Token: 0x04004C47 RID: 19527
		[Token(Token = "0x4004C47")]
		[FieldOffset(Offset = "0x18")]
		private object m_Locker;

		// Token: 0x04004C48 RID: 19528
		[Token(Token = "0x4004C48")]
		[FieldOffset(Offset = "0x20")]
		private bool m_FlushForLongDeactiveTime;

		// Token: 0x04004C49 RID: 19529
		[Token(Token = "0x4004C49")]
		[FieldOffset(Offset = "0x28")]
		private double m_LastFlushTime;

		// Token: 0x04004C4A RID: 19530
		[Token(Token = "0x4004C4A")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<UDPMsgPacket, UDPMsgPacketResendInfo> m_ResendPacketInfo;

		// Token: 0x04004C4B RID: 19531
		[Token(Token = "0x4004C4B")]
		[FieldOffset(Offset = "0x38")]
		private LinkedList<UDPMsgPacketTrackingData> m_PendingAckPacket;

		// Token: 0x04004C4C RID: 19532
		[Token(Token = "0x4004C4C")]
		[FieldOffset(Offset = "0x40")]
		private LinkedList<ushort> m_AckSent;

		// Token: 0x04004C4D RID: 19533
		[Token(Token = "0x4004C4D")]
		[FieldOffset(Offset = "0x0")]
		private static UDPReliableTracking.PacketTrackingDataComparer m_PacketTrackingDataComparer;

		// Token: 0x02000FBA RID: 4026
		[Token(Token = "0x2000FBA")]
		public class CircularValue
		{
			// Token: 0x06003AB0 RID: 15024 RVA: 0x000123A8 File Offset: 0x000105A8
			[Token(Token = "0x6003AB0")]
			[Address(RVA = "0x201B0CC", Offset = "0x201B0CC", VA = "0x7BBC81B0CC")]
			public static ushort Inc(ushort v, ushort step, ushort maxValue = 65535)
			{
				return 0;
			}

			// Token: 0x06003AB1 RID: 15025 RVA: 0x000123C0 File Offset: 0x000105C0
			[Token(Token = "0x6003AB1")]
			[Address(RVA = "0x201A5B4", Offset = "0x201A5B4", VA = "0x7BBC81A5B4")]
			public static bool Greater(ushort v1, ushort v2, ushort maxValue = 65535)
			{
				return default(bool);
			}

			// Token: 0x06003AB2 RID: 15026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB2")]
			[Address(RVA = "0x201B7BC", Offset = "0x201B7BC", VA = "0x7BBC81B7BC")]
			public CircularValue()
			{
			}
		}

		// Token: 0x02000FBB RID: 4027
		[Token(Token = "0x2000FBB")]
		public enum RECVRET
		{
			// Token: 0x04004C4F RID: 19535
			[Token(Token = "0x4004C4F")]
			ENQUEUE,
			// Token: 0x04004C50 RID: 19536
			[Token(Token = "0x4004C50")]
			PENDING,
			// Token: 0x04004C51 RID: 19537
			[Token(Token = "0x4004C51")]
			DROP
		}

		// Token: 0x02000FBC RID: 4028
		[Token(Token = "0x2000FBC")]
		private class PacketTrackingDataComparer : IComparer<UDPMsgPacketTrackingData>
		{
			// Token: 0x06003AB3 RID: 15027 RVA: 0x000123D8 File Offset: 0x000105D8
			[Token(Token = "0x6003AB3")]
			[Address(RVA = "0x201B7C4", Offset = "0x201B7C4", VA = "0x7BBC81B7C4", Slot = "4")]
			public int Compare(UDPMsgPacketTrackingData x, UDPMsgPacketTrackingData y)
			{
				return 0;
			}

			// Token: 0x06003AB4 RID: 15028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x201B7B4", Offset = "0x201B7B4", VA = "0x7BBC81B7B4")]
			public PacketTrackingDataComparer()
			{
			}
		}
	}
}
