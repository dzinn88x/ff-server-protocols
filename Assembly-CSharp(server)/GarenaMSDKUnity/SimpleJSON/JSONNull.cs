using System;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BBB RID: 11195
	[Token(Token = "0x2002BBB")]
	public class JSONNull : JSONNode
	{
		// Token: 0x0600F7DA RID: 63450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F7DA")]
		[Address(RVA = "0x2743124", Offset = "0x2743124", VA = "0x7BBCF43124")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		// Token: 0x0600F7DB RID: 63451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7DB")]
		[Address(RVA = "0x2746E8C", Offset = "0x2746E8C", VA = "0x7BBCF46E8C")]
		private JSONNull()
		{
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600F7DC RID: 63452 RVA: 0x00047508 File Offset: 0x00045708
		[Token(Token = "0x170011FD")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600F7DC")]
			[Address(RVA = "0x2746EF4", Offset = "0x2746EF4", VA = "0x7BBCF46EF4", Slot = "4")]
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600F7DD RID: 63453 RVA: 0x00047520 File Offset: 0x00045720
		[Token(Token = "0x170011FE")]
		public override bool IsNull
		{
			[Token(Token = "0x600F7DD")]
			[Address(RVA = "0x2746EFC", Offset = "0x2746EFC", VA = "0x7BBCF46EFC", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F7DE RID: 63454 RVA: 0x00047538 File Offset: 0x00045738
		[Token(Token = "0x600F7DE")]
		[Address(RVA = "0x2746F04", Offset = "0x2746F04", VA = "0x7BBCF46F04", Slot = "28")]
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x0600F7DF RID: 63455 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7E0 RID: 63456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011FF")]
		public override string Value
		{
			[Token(Token = "0x600F7DF")]
			[Address(RVA = "0x2746F24", Offset = "0x2746F24", VA = "0x7BBCF46F24", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7E0")]
			[Address(RVA = "0x2746F6C", Offset = "0x2746F6C", VA = "0x7BBCF46F6C", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x0600F7E1 RID: 63457 RVA: 0x00047550 File Offset: 0x00045750
		// (set) Token: 0x0600F7E2 RID: 63458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001200")]
		public override bool AsBool
		{
			[Token(Token = "0x600F7E1")]
			[Address(RVA = "0x2746F70", Offset = "0x2746F70", VA = "0x7BBCF46F70", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F7E2")]
			[Address(RVA = "0x2746F78", Offset = "0x2746F78", VA = "0x7BBCF46F78", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x0600F7E3 RID: 63459 RVA: 0x00047568 File Offset: 0x00045768
		[Token(Token = "0x600F7E3")]
		[Address(RVA = "0x2746F7C", Offset = "0x2746F7C", VA = "0x7BBCF46F7C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600F7E4 RID: 63460 RVA: 0x00047580 File Offset: 0x00045780
		[Token(Token = "0x600F7E4")]
		[Address(RVA = "0x2747018", Offset = "0x2747018", VA = "0x7BBCF47018", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600F7E5 RID: 63461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7E5")]
		[Address(RVA = "0x2747020", Offset = "0x2747020", VA = "0x7BBCF47020", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x04011B66 RID: 72550
		[Token(Token = "0x4011B66")]
		[FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		// Token: 0x04011B67 RID: 72551
		[Token(Token = "0x4011B67")]
		[FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;
	}
}
