using System;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BB9 RID: 11193
	[Token(Token = "0x2002BB9")]
	public class JSONNumber : JSONNode
	{
		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600F7C1 RID: 63425 RVA: 0x000473D0 File Offset: 0x000455D0
		[Token(Token = "0x170011F5")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600F7C1")]
			[Address(RVA = "0x27470F0", Offset = "0x27470F0", VA = "0x7BBCF470F0", Slot = "4")]
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x0600F7C2 RID: 63426 RVA: 0x000473E8 File Offset: 0x000455E8
		[Token(Token = "0x170011F6")]
		public override bool IsNumber
		{
			[Token(Token = "0x600F7C2")]
			[Address(RVA = "0x27470F8", Offset = "0x27470F8", VA = "0x7BBCF470F8", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F7C3 RID: 63427 RVA: 0x00047400 File Offset: 0x00045600
		[Token(Token = "0x600F7C3")]
		[Address(RVA = "0x2747100", Offset = "0x2747100", VA = "0x7BBCF47100", Slot = "28")]
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x0600F7C4 RID: 63428 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7C5 RID: 63429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011F7")]
		public override string Value
		{
			[Token(Token = "0x600F7C4")]
			[Address(RVA = "0x2747120", Offset = "0x2747120", VA = "0x7BBCF47120", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7C5")]
			[Address(RVA = "0x274712C", Offset = "0x274712C", VA = "0x7BBCF4712C", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600F7C6 RID: 63430 RVA: 0x00047418 File Offset: 0x00045618
		// (set) Token: 0x0600F7C7 RID: 63431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011F8")]
		public override double AsDouble
		{
			[Token(Token = "0x600F7C6")]
			[Address(RVA = "0x27471B8", Offset = "0x27471B8", VA = "0x7BBCF471B8", Slot = "29")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600F7C7")]
			[Address(RVA = "0x27471C0", Offset = "0x27471C0", VA = "0x7BBCF471C0", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x0600F7C8 RID: 63432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7C8")]
		[Address(RVA = "0x2744460", Offset = "0x2744460", VA = "0x7BBCF44460")]
		public JSONNumber(double aData)
		{
		}

		// Token: 0x0600F7C9 RID: 63433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7C9")]
		[Address(RVA = "0x27471C8", Offset = "0x27471C8", VA = "0x7BBCF471C8")]
		public JSONNumber(string aData)
		{
		}

		// Token: 0x0600F7CA RID: 63434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7CA")]
		[Address(RVA = "0x2747250", Offset = "0x2747250", VA = "0x7BBCF47250", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x0600F7CB RID: 63435 RVA: 0x00047430 File Offset: 0x00045630
		[Token(Token = "0x600F7CB")]
		[Address(RVA = "0x2747290", Offset = "0x2747290", VA = "0x7BBCF47290")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		// Token: 0x0600F7CC RID: 63436 RVA: 0x00047448 File Offset: 0x00045648
		[Token(Token = "0x600F7CC")]
		[Address(RVA = "0x27473C0", Offset = "0x27473C0", VA = "0x7BBCF473C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600F7CD RID: 63437 RVA: 0x00047460 File Offset: 0x00045660
		[Token(Token = "0x600F7CD")]
		[Address(RVA = "0x27474FC", Offset = "0x27474FC", VA = "0x7BBCF474FC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04011B64 RID: 72548
		[Token(Token = "0x4011B64")]
		[FieldOffset(Offset = "0x10")]
		private double m_Data;
	}
}
