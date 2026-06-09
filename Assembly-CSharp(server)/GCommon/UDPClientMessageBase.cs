using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FAB RID: 4011
	[Token(Token = "0x2000FAB")]
	public class UDPClientMessageBase : IClientMessageSerializer
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x00012108 File Offset: 0x00010308
		// (set) Token: 0x06003A65 RID: 14949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E8")]
		public bool GetFromPool
		{
			[Token(Token = "0x6003A64")]
			[Address(RVA = "0x20181B4", Offset = "0x20181B4", VA = "0x7BBC8181B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A65")]
			[Address(RVA = "0x20181BC", Offset = "0x20181BC", VA = "0x7BBC8181BC")]
			set
			{
			}
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A66")]
		[Address(RVA = "0x20181C8", Offset = "0x20181C8", VA = "0x7BBC8181C8")]
		public static UDPClientMessageBase UnSerializeMessage(BinaryReader reader, Type type)
		{
			return null;
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x2018390", Offset = "0x2018390", VA = "0x7BBC818390")]
		protected void WriteString(BinaryWriter writer, string value)
		{
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A68")]
		[Address(RVA = "0x2018444", Offset = "0x2018444", VA = "0x7BBC818444")]
		protected string ReadString(BinaryReader reader, ref ushort readsize)
		{
			return null;
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x00012120 File Offset: 0x00010320
		[Token(Token = "0x6003A69")]
		[Address(RVA = "0x2018540", Offset = "0x2018540", VA = "0x7BBC818540")]
		protected sbyte ReadSByte(BinaryReader reader, ref ushort readsize)
		{
			return 0;
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x6003A6A")]
		[Address(RVA = "0x2018598", Offset = "0x2018598", VA = "0x7BBC818598")]
		protected short ReadInt16(BinaryReader reader, ref ushort readsize)
		{
			return 0;
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00012150 File Offset: 0x00010350
		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x20185F4", Offset = "0x20185F4", VA = "0x7BBC8185F4")]
		protected int ReadInt32(BinaryReader reader, ref ushort readsize)
		{
			return 0;
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x2018650", Offset = "0x2018650", VA = "0x7BBC818650")]
		protected long ReadInt64(BinaryReader reader, ref ushort readsize)
		{
			return 0L;
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00012180 File Offset: 0x00010380
		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x20186AC", Offset = "0x20186AC", VA = "0x7BBC8186AC")]
		protected byte ReadByte(BinaryReader reader, ref ushort readsize)
		{
			return 0;
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00012198 File Offset: 0x00010398
		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0x2018704", Offset = "0x2018704", VA = "0x7BBC818704")]
		protected ushort ReadUInt16(BinaryReader reader, ref ushort readsize)
		{
			return 0;
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x2018760", Offset = "0x2018760", VA = "0x7BBC818760")]
		protected uint ReadUInt32(BinaryReader reader, ref ushort readsize)
		{
			return 0U;
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x6003A70")]
		[Address(RVA = "0x20187BC", Offset = "0x20187BC", VA = "0x7BBC8187BC")]
		protected ulong ReadUInt64(BinaryReader reader, ref ushort readsize)
		{
			return 0UL;
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x000121E0 File Offset: 0x000103E0
		[Token(Token = "0x6003A71")]
		[Address(RVA = "0x2018818", Offset = "0x2018818", VA = "0x7BBC818818")]
		protected float ReadSingle(BinaryReader reader, ref ushort readsize)
		{
			return 0f;
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x000121F8 File Offset: 0x000103F8
		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x2018874", Offset = "0x2018874", VA = "0x7BBC818874")]
		protected double ReadDouble(BinaryReader reader, ref ushort readsize)
		{
			return 0.0;
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x00012210 File Offset: 0x00010410
		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x20188D0", Offset = "0x20188D0", VA = "0x7BBC8188D0")]
		protected bool ReadBoolean(BinaryReader reader, ref ushort readsize)
		{
			return default(bool);
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x2018928", Offset = "0x2018928", VA = "0x7BBC818928", Slot = "6")]
		public virtual void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A75")]
		[Address(RVA = "0x201899C", Offset = "0x201899C", VA = "0x7BBC81899C", Slot = "7")]
		public virtual void UnSerialize(BinaryReader reader)
		{
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x2018A10", Offset = "0x2018A10", VA = "0x7BBC818A10", Slot = "8")]
		public virtual bool CanCache()
		{
			return default(bool);
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A77")]
		[Address(RVA = "0x2018A18", Offset = "0x2018A18", VA = "0x7BBC818A18", Slot = "9")]
		public virtual void Recycle()
		{
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A78")]
		[Address(RVA = "0x2018A1C", Offset = "0x2018A1C", VA = "0x7BBC818A1C")]
		public UDPClientMessageBase()
		{
		}

		// Token: 0x04004C00 RID: 19456
		[Token(Token = "0x4004C00")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, UDPClientMessageBase> CachedMessage;

		// Token: 0x04004C01 RID: 19457
		[Token(Token = "0x4004C01")]
		public const uint USER_MESSAGE_ID_START = 100U;

		// Token: 0x04004C02 RID: 19458
		[Token(Token = "0x4004C02")]
		[FieldOffset(Offset = "0x10")]
		private bool m_GetFromPool;
	}
}
