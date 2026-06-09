using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BAB RID: 11179
	[Token(Token = "0x2002BAB")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x10FF694", Offset = "0x10FF694")]
	public abstract class JSONNode
	{
		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x0600F71B RID: 63259
		[Token(Token = "0x170011BE")]
		public abstract JSONNodeType Tag { [Token(Token = "0x600F71B")] get; }

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x0600F71C RID: 63260 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F71D RID: 63261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011BF")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x600F71C")]
			[Address(RVA = "0x2744910", Offset = "0x2744910", VA = "0x7BBCF44910", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F71D")]
			[Address(RVA = "0x2744918", Offset = "0x2744918", VA = "0x7BBCF44918", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x0600F71E RID: 63262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F71F RID: 63263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011C0")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x600F71E")]
			[Address(RVA = "0x274491C", Offset = "0x274491C", VA = "0x7BBCF4491C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F71F")]
			[Address(RVA = "0x2744924", Offset = "0x2744924", VA = "0x7BBCF44924", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600F720 RID: 63264 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F721 RID: 63265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011C1")]
		public virtual string Value
		{
			[Token(Token = "0x600F720")]
			[Address(RVA = "0x2744928", Offset = "0x2744928", VA = "0x7BBCF44928", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F721")]
			[Address(RVA = "0x2744970", Offset = "0x2744970", VA = "0x7BBCF44970", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600F722 RID: 63266 RVA: 0x00046F08 File Offset: 0x00045108
		[Token(Token = "0x170011C2")]
		public virtual int Count
		{
			[Token(Token = "0x600F722")]
			[Address(RVA = "0x2744974", Offset = "0x2744974", VA = "0x7BBCF44974", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600F723 RID: 63267 RVA: 0x00046F20 File Offset: 0x00045120
		[Token(Token = "0x170011C3")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600F723")]
			[Address(RVA = "0x274497C", Offset = "0x274497C", VA = "0x7BBCF4497C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600F724 RID: 63268 RVA: 0x00046F38 File Offset: 0x00045138
		[Token(Token = "0x170011C4")]
		public virtual bool IsString
		{
			[Token(Token = "0x600F724")]
			[Address(RVA = "0x2744984", Offset = "0x2744984", VA = "0x7BBCF44984", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600F725 RID: 63269 RVA: 0x00046F50 File Offset: 0x00045150
		[Token(Token = "0x170011C5")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x600F725")]
			[Address(RVA = "0x274498C", Offset = "0x274498C", VA = "0x7BBCF4498C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600F726 RID: 63270 RVA: 0x00046F68 File Offset: 0x00045168
		[Token(Token = "0x170011C6")]
		public virtual bool IsNull
		{
			[Token(Token = "0x600F726")]
			[Address(RVA = "0x2744994", Offset = "0x2744994", VA = "0x7BBCF44994", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600F727 RID: 63271 RVA: 0x00046F80 File Offset: 0x00045180
		[Token(Token = "0x170011C7")]
		public virtual bool IsArray
		{
			[Token(Token = "0x600F727")]
			[Address(RVA = "0x274499C", Offset = "0x274499C", VA = "0x7BBCF4499C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x0600F728 RID: 63272 RVA: 0x00046F98 File Offset: 0x00045198
		[Token(Token = "0x170011C8")]
		public virtual bool IsObject
		{
			[Token(Token = "0x600F728")]
			[Address(RVA = "0x27449A4", Offset = "0x27449A4", VA = "0x7BBCF449A4", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x0600F729 RID: 63273 RVA: 0x00046FB0 File Offset: 0x000451B0
		// (set) Token: 0x0600F72A RID: 63274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011C9")]
		public virtual bool Inline
		{
			[Token(Token = "0x600F729")]
			[Address(RVA = "0x27449AC", Offset = "0x27449AC", VA = "0x7BBCF449AC", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F72A")]
			[Address(RVA = "0x27449B4", Offset = "0x27449B4", VA = "0x7BBCF449B4", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x0600F72B RID: 63275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F72B")]
		[Address(RVA = "0x27449B8", Offset = "0x27449B8", VA = "0x7BBCF449B8", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x0600F72C RID: 63276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F72C")]
		[Address(RVA = "0x27449BC", Offset = "0x27449BC", VA = "0x7BBCF449BC", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		// Token: 0x0600F72D RID: 63277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F72D")]
		[Address(RVA = "0x2744A28", Offset = "0x2744A28", VA = "0x7BBCF44A28", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x0600F72E RID: 63278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F72E")]
		[Address(RVA = "0x2744A30", Offset = "0x2744A30", VA = "0x7BBCF44A30", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x0600F72F RID: 63279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F72F")]
		[Address(RVA = "0x2744A38", Offset = "0x2744A38", VA = "0x7BBCF44A38", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x0600F730 RID: 63280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011CA")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600F730")]
			[Address(RVA = "0x2744A40", Offset = "0x2744A40", VA = "0x7BBCF44A40", Slot = "25")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114B7D8", Offset = "0x114B7D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600F731 RID: 63281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011CB")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x600F731")]
			[Address(RVA = "0x2744AE8", Offset = "0x2744AE8", VA = "0x7BBCF44AE8")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114B83C", Offset = "0x114B83C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F732 RID: 63282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F732")]
		[Address(RVA = "0x2744BA4", Offset = "0x2744BA4", VA = "0x7BBCF44BA4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F733")]
		[Address(RVA = "0x2744C3C", Offset = "0x2744C3C", VA = "0x7BBCF44C3C", Slot = "26")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		// Token: 0x0600F734 RID: 63284
		[Token(Token = "0x600F734")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		// Token: 0x0600F735 RID: 63285
		[Token(Token = "0x600F735")]
		public abstract JSONNode.Enumerator GetEnumerator();

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600F736 RID: 63286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011CC")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x600F736")]
			[Address(RVA = "0x2744CE0", Offset = "0x2744CE0", VA = "0x7BBCF44CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600F737 RID: 63287 RVA: 0x00046FC8 File Offset: 0x000451C8
		[Token(Token = "0x170011CD")]
		public JSONNode.KeyEnumerator Keys
		{
			[Token(Token = "0x600F737")]
			[Address(RVA = "0x2744E0C", Offset = "0x2744E0C", VA = "0x7BBCF44E0C")]
			get
			{
				return default(JSONNode.KeyEnumerator);
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600F738 RID: 63288 RVA: 0x00046FE0 File Offset: 0x000451E0
		[Token(Token = "0x170011CE")]
		public JSONNode.ValueEnumerator Values
		{
			[Token(Token = "0x600F738")]
			[Address(RVA = "0x2744E6C", Offset = "0x2744E6C", VA = "0x7BBCF44E6C")]
			get
			{
				return default(JSONNode.ValueEnumerator);
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600F739 RID: 63289 RVA: 0x00046FF8 File Offset: 0x000451F8
		// (set) Token: 0x0600F73A RID: 63290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011CF")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600F739")]
			[Address(RVA = "0x2744ECC", Offset = "0x2744ECC", VA = "0x7BBCF44ECC", Slot = "29")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600F73A")]
			[Address(RVA = "0x2744F70", Offset = "0x2744F70", VA = "0x7BBCF44F70", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600F73B RID: 63291 RVA: 0x00047010 File Offset: 0x00045210
		// (set) Token: 0x0600F73C RID: 63292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011D0")]
		public virtual int AsInt
		{
			[Token(Token = "0x600F73B")]
			[Address(RVA = "0x2744FB0", Offset = "0x2744FB0", VA = "0x7BBCF44FB0", Slot = "31")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600F73C")]
			[Address(RVA = "0x2744FD4", Offset = "0x2744FD4", VA = "0x7BBCF44FD4", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600F73D RID: 63293 RVA: 0x00047028 File Offset: 0x00045228
		// (set) Token: 0x0600F73E RID: 63294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011D1")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600F73D")]
			[Address(RVA = "0x2744FEC", Offset = "0x2744FEC", VA = "0x7BBCF44FEC", Slot = "33")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600F73E")]
			[Address(RVA = "0x2745010", Offset = "0x2745010", VA = "0x7BBCF45010", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x0600F73F RID: 63295 RVA: 0x00047040 File Offset: 0x00045240
		// (set) Token: 0x0600F740 RID: 63296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011D2")]
		public virtual bool AsBool
		{
			[Token(Token = "0x600F73F")]
			[Address(RVA = "0x2745024", Offset = "0x2745024", VA = "0x7BBCF45024", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F740")]
			[Address(RVA = "0x27450EC", Offset = "0x27450EC", VA = "0x7BBCF450EC", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x0600F741 RID: 63297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011D3")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x600F741")]
			[Address(RVA = "0x2745170", Offset = "0x2745170", VA = "0x7BBCF45170", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600F742 RID: 63298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011D4")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x600F742")]
			[Address(RVA = "0x27451F0", Offset = "0x27451F0", VA = "0x7BBCF451F0", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F743 RID: 63299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F743")]
		[Address(RVA = "0x2745270", Offset = "0x2745270", VA = "0x7BBCF45270")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		// Token: 0x0600F744 RID: 63300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F744")]
		[Address(RVA = "0x274534C", Offset = "0x274534C", VA = "0x7BBCF4534C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		// Token: 0x0600F745 RID: 63301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F745")]
		[Address(RVA = "0x27453E4", Offset = "0x27453E4", VA = "0x7BBCF453E4")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		// Token: 0x0600F746 RID: 63302 RVA: 0x00047058 File Offset: 0x00045258
		[Token(Token = "0x600F746")]
		[Address(RVA = "0x274544C", Offset = "0x274544C", VA = "0x7BBCF4544C")]
		public static implicit operator double(JSONNode d)
		{
			return 0.0;
		}

		// Token: 0x0600F747 RID: 63303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F747")]
		[Address(RVA = "0x27454E8", Offset = "0x27454E8", VA = "0x7BBCF454E8")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		// Token: 0x0600F748 RID: 63304 RVA: 0x00047070 File Offset: 0x00045270
		[Token(Token = "0x600F748")]
		[Address(RVA = "0x2745550", Offset = "0x2745550", VA = "0x7BBCF45550")]
		public static implicit operator float(JSONNode d)
		{
			return 0f;
		}

		// Token: 0x0600F749 RID: 63305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F749")]
		[Address(RVA = "0x27455EC", Offset = "0x27455EC", VA = "0x7BBCF455EC")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		// Token: 0x0600F74A RID: 63306 RVA: 0x00047088 File Offset: 0x00045288
		[Token(Token = "0x600F74A")]
		[Address(RVA = "0x274564C", Offset = "0x274564C", VA = "0x7BBCF4564C")]
		public static implicit operator int(JSONNode d)
		{
			return 0;
		}

		// Token: 0x0600F74B RID: 63307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F74B")]
		[Address(RVA = "0x27456E8", Offset = "0x27456E8", VA = "0x7BBCF456E8")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		// Token: 0x0600F74C RID: 63308 RVA: 0x000470A0 File Offset: 0x000452A0
		[Token(Token = "0x600F74C")]
		[Address(RVA = "0x2745748", Offset = "0x2745748", VA = "0x7BBCF45748")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		// Token: 0x0600F74D RID: 63309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F74D")]
		[Address(RVA = "0x27457E4", Offset = "0x27457E4", VA = "0x7BBCF457E4")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		// Token: 0x0600F74E RID: 63310 RVA: 0x000470B8 File Offset: 0x000452B8
		[Token(Token = "0x600F74E")]
		[Address(RVA = "0x2742F94", Offset = "0x2742F94", VA = "0x7BBCF42F94")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600F74F RID: 63311 RVA: 0x000470D0 File Offset: 0x000452D0
		[Token(Token = "0x600F74F")]
		[Address(RVA = "0x2745840", Offset = "0x2745840", VA = "0x7BBCF45840")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600F750 RID: 63312 RVA: 0x000470E8 File Offset: 0x000452E8
		[Token(Token = "0x600F750")]
		[Address(RVA = "0x27458C0", Offset = "0x27458C0", VA = "0x7BBCF458C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600F751 RID: 63313 RVA: 0x00047100 File Offset: 0x00045300
		[Token(Token = "0x600F751")]
		[Address(RVA = "0x27458CC", Offset = "0x27458CC", VA = "0x7BBCF458CC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600F752 RID: 63314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011D5")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x600F752")]
			[Address(RVA = "0x27458D4", Offset = "0x27458D4", VA = "0x7BBCF458D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F753 RID: 63315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F753")]
		[Address(RVA = "0x27459B0", Offset = "0x27459B0", VA = "0x7BBCF459B0")]
		internal static string Escape(string aText)
		{
			return null;
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F754")]
		[Address(RVA = "0x2745DC4", Offset = "0x2745DC4", VA = "0x7BBCF45DC4")]
		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F755")]
		[Address(RVA = "0x27424F0", Offset = "0x27424F0", VA = "0x7BBCF424F0")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		// Token: 0x0600F756 RID: 63318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F756")]
		[Address(RVA = "0x27438B0", Offset = "0x27438B0", VA = "0x7BBCF438B0")]
		protected JSONNode()
		{
		}

		// Token: 0x04011B3E RID: 72510
		[Token(Token = "0x4011B3E")]
		[FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		// Token: 0x04011B3F RID: 72511
		[Token(Token = "0x4011B3F")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		// Token: 0x02002BAC RID: 11180
		[Token(Token = "0x2002BAC")]
		public struct Enumerator
		{
			// Token: 0x170011D6 RID: 4566
			// (get) Token: 0x0600F758 RID: 63320 RVA: 0x00047118 File Offset: 0x00045318
			[Token(Token = "0x170011D6")]
			public bool IsValid
			{
				[Token(Token = "0x600F758")]
				[Address(RVA = "0x11FFC5C", Offset = "0x11FFC5C", VA = "0x7BBB9FFC5C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600F759 RID: 63321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F759")]
			[Address(RVA = "0x11FFC6C", Offset = "0x11FFC6C", VA = "0x7BBB9FFC6C")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			// Token: 0x0600F75A RID: 63322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F75A")]
			[Address(RVA = "0x11FFCAC", Offset = "0x11FFCAC", VA = "0x7BBB9FFCAC")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			// Token: 0x170011D7 RID: 4567
			// (get) Token: 0x0600F75B RID: 63323 RVA: 0x00047130 File Offset: 0x00045330
			[Token(Token = "0x170011D7")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x600F75B")]
				[Address(RVA = "0x11FFCF0", Offset = "0x11FFCF0", VA = "0x7BBB9FFCF0")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			// Token: 0x0600F75C RID: 63324 RVA: 0x00047148 File Offset: 0x00045348
			[Token(Token = "0x600F75C")]
			[Address(RVA = "0x11FFCF8", Offset = "0x11FFCF8", VA = "0x7BBB9FFCF8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x04011B40 RID: 72512
			[Token(Token = "0x4011B40")]
			[FieldOffset(Offset = "0x0")]
			private JSONNode.Enumerator.Type type;

			// Token: 0x04011B41 RID: 72513
			[Token(Token = "0x4011B41")]
			[FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			// Token: 0x04011B42 RID: 72514
			[Token(Token = "0x4011B42")]
			[FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			// Token: 0x02002BAD RID: 11181
			[Token(Token = "0x2002BAD")]
			private enum Type
			{
				// Token: 0x04011B44 RID: 72516
				[Token(Token = "0x4011B44")]
				None,
				// Token: 0x04011B45 RID: 72517
				[Token(Token = "0x4011B45")]
				Array,
				// Token: 0x04011B46 RID: 72518
				[Token(Token = "0x4011B46")]
				Object
			}
		}

		// Token: 0x02002BAE RID: 11182
		[Token(Token = "0x2002BAE")]
		public struct ValueEnumerator
		{
			// Token: 0x0600F75D RID: 63325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F75D")]
			[Address(RVA = "0x11FFE60", Offset = "0x11FFE60", VA = "0x7BBB9FFE60")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			// Token: 0x0600F75E RID: 63326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F75E")]
			[Address(RVA = "0x11FFEA4", Offset = "0x11FFEA4", VA = "0x7BBB9FFEA4")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			// Token: 0x0600F75F RID: 63327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F75F")]
			[Address(RVA = "0x11FFEEC", Offset = "0x11FFEEC", VA = "0x7BBB9FFEEC")]
			public ValueEnumerator(JSONNode.Enumerator aEnumerator)
			{
			}

			// Token: 0x170011D8 RID: 4568
			// (get) Token: 0x0600F760 RID: 63328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011D8")]
			public JSONNode Current
			{
				[Token(Token = "0x600F760")]
				[Address(RVA = "0x11FFF08", Offset = "0x11FFF08", VA = "0x7BBB9FFF08")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F761 RID: 63329 RVA: 0x00047160 File Offset: 0x00045360
			[Token(Token = "0x600F761")]
			[Address(RVA = "0x11FFF10", Offset = "0x11FFF10", VA = "0x7BBB9FFF10")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600F762 RID: 63330 RVA: 0x00047178 File Offset: 0x00045378
			[Token(Token = "0x600F762")]
			[Address(RVA = "0x11FFF18", Offset = "0x11FFF18", VA = "0x7BBB9FFF18")]
			public JSONNode.ValueEnumerator GetEnumerator()
			{
				return default(JSONNode.ValueEnumerator);
			}

			// Token: 0x04011B47 RID: 72519
			[Token(Token = "0x4011B47")]
			[FieldOffset(Offset = "0x0")]
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x02002BAF RID: 11183
		[Token(Token = "0x2002BAF")]
		public struct KeyEnumerator
		{
			// Token: 0x0600F763 RID: 63331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F763")]
			[Address(RVA = "0x11FFD4C", Offset = "0x11FFD4C", VA = "0x7BBB9FFD4C")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			// Token: 0x0600F764 RID: 63332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F764")]
			[Address(RVA = "0x11FFD90", Offset = "0x11FFD90", VA = "0x7BBB9FFD90")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			// Token: 0x0600F765 RID: 63333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F765")]
			[Address(RVA = "0x11FFDD8", Offset = "0x11FFDD8", VA = "0x7BBB9FFDD8")]
			public KeyEnumerator(JSONNode.Enumerator aEnumerator)
			{
			}

			// Token: 0x170011D9 RID: 4569
			// (get) Token: 0x0600F766 RID: 63334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011D9")]
			public JSONNode Current
			{
				[Token(Token = "0x600F766")]
				[Address(RVA = "0x11FFDF4", Offset = "0x11FFDF4", VA = "0x7BBB9FFDF4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F767 RID: 63335 RVA: 0x00047190 File Offset: 0x00045390
			[Token(Token = "0x600F767")]
			[Address(RVA = "0x11FFDFC", Offset = "0x11FFDFC", VA = "0x7BBB9FFDFC")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600F768 RID: 63336 RVA: 0x000471A8 File Offset: 0x000453A8
			[Token(Token = "0x600F768")]
			[Address(RVA = "0x11FFE04", Offset = "0x11FFE04", VA = "0x7BBB9FFE04")]
			public JSONNode.KeyEnumerator GetEnumerator()
			{
				return default(JSONNode.KeyEnumerator);
			}

			// Token: 0x04011B48 RID: 72520
			[Token(Token = "0x4011B48")]
			[FieldOffset(Offset = "0x0")]
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x02002BB0 RID: 11184
		[Token(Token = "0x2002BB0")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			// Token: 0x0600F769 RID: 63337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F769")]
			[Address(RVA = "0x2744D40", Offset = "0x2744D40", VA = "0x7BBCF44D40")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			// Token: 0x170011DA RID: 4570
			// (get) Token: 0x0600F76A RID: 63338 RVA: 0x000471C0 File Offset: 0x000453C0
			[Token(Token = "0x170011DA")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x600F76A")]
				[Address(RVA = "0x2746B5C", Offset = "0x2746B5C", VA = "0x7BBCF46B5C", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			// Token: 0x170011DB RID: 4571
			// (get) Token: 0x0600F76B RID: 63339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011DB")]
			private object Current
			{
				[Token(Token = "0x600F76B")]
				[Address(RVA = "0x2746B64", Offset = "0x2746B64", VA = "0x7BBCF46B64", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F76C RID: 63340 RVA: 0x000471D8 File Offset: 0x000453D8
			[Token(Token = "0x600F76C")]
			[Address(RVA = "0x2746BD0", Offset = "0x2746BD0", VA = "0x7BBCF46BD0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600F76D RID: 63341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F76D")]
			[Address(RVA = "0x2746BD8", Offset = "0x2746BD8", VA = "0x7BBCF46BD8", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x0600F76E RID: 63342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F76E")]
			[Address(RVA = "0x2746BF8", Offset = "0x2746BF8", VA = "0x7BBCF46BF8", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600F76F RID: 63343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F76F")]
			[Address(RVA = "0x2746C5C", Offset = "0x2746C5C", VA = "0x7BBCF46C5C", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x0600F770 RID: 63344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F770")]
			[Address(RVA = "0x2746D10", Offset = "0x2746D10", VA = "0x7BBCF46D10", Slot = "10")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04011B49 RID: 72521
			[Token(Token = "0x4011B49")]
			[FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			// Token: 0x04011B4A RID: 72522
			[Token(Token = "0x4011B4A")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode.Enumerator m_Enumerator;
		}

		// Token: 0x02002BB1 RID: 11185
		[Token(Token = "0x2002BB1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF6CC", Offset = "0x10FF6CC")]
		private sealed class <get_Children>d__39 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x0600F771 RID: 63345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F771")]
			[Address(RVA = "0x2744AB0", Offset = "0x2744AB0", VA = "0x7BBCF44AB0")]
			[DebuggerHidden]
			public <get_Children>d__39(int <>1__state)
			{
			}

			// Token: 0x0600F772 RID: 63346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F772")]
			[Address(RVA = "0x2745FCC", Offset = "0x2745FCC", VA = "0x7BBCF45FCC", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600F773 RID: 63347 RVA: 0x000471F0 File Offset: 0x000453F0
			[Token(Token = "0x600F773")]
			[Address(RVA = "0x2745FD0", Offset = "0x2745FD0", VA = "0x7BBCF45FD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170011DC RID: 4572
			// (get) Token: 0x0600F774 RID: 63348 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011DC")]
			private JSONNode Current
			{
				[Token(Token = "0x600F774")]
				[Address(RVA = "0x2745FE8", Offset = "0x2745FE8", VA = "0x7BBCF45FE8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F775 RID: 63349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F775")]
			[Address(RVA = "0x2745FF0", Offset = "0x2745FF0", VA = "0x7BBCF45FF0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170011DD RID: 4573
			// (get) Token: 0x0600F776 RID: 63350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011DD")]
			private object Current
			{
				[Token(Token = "0x600F776")]
				[Address(RVA = "0x2746058", Offset = "0x2746058", VA = "0x7BBCF46058", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F777 RID: 63351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F777")]
			[Address(RVA = "0x2746060", Offset = "0x2746060", VA = "0x7BBCF46060", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600F778 RID: 63352 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F778")]
			[Address(RVA = "0x27460F8", Offset = "0x27460F8", VA = "0x7BBCF460F8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04011B4B RID: 72523
			[Token(Token = "0x4011B4B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04011B4C RID: 72524
			[Token(Token = "0x4011B4C")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x04011B4D RID: 72525
			[Token(Token = "0x4011B4D")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;
		}

		// Token: 0x02002BB2 RID: 11186
		[Token(Token = "0x2002BB2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF6DC", Offset = "0x10FF6DC")]
		private sealed class <get_DeepChildren>d__41 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x0600F779 RID: 63353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F779")]
			[Address(RVA = "0x2744B6C", Offset = "0x2744B6C", VA = "0x7BBCF44B6C")]
			[DebuggerHidden]
			public <get_DeepChildren>d__41(int <>1__state)
			{
			}

			// Token: 0x0600F77A RID: 63354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F77A")]
			[Address(RVA = "0x27460FC", Offset = "0x27460FC", VA = "0x7BBCF460FC", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600F77B RID: 63355 RVA: 0x00047208 File Offset: 0x00045408
			[Token(Token = "0x600F77B")]
			[Address(RVA = "0x27462F4", Offset = "0x27462F4", VA = "0x7BBCF462F4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600F77C RID: 63356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F77C")]
			[Address(RVA = "0x2746234", Offset = "0x2746234", VA = "0x7BBCF46234")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x0600F77D RID: 63357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F77D")]
			[Address(RVA = "0x2746174", Offset = "0x2746174", VA = "0x7BBCF46174")]
			private void <>m__Finally2()
			{
			}

			// Token: 0x170011DE RID: 4574
			// (get) Token: 0x0600F77E RID: 63358 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011DE")]
			private JSONNode Current
			{
				[Token(Token = "0x600F77E")]
				[Address(RVA = "0x2746730", Offset = "0x2746730", VA = "0x7BBCF46730", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F77F RID: 63359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F77F")]
			[Address(RVA = "0x2746738", Offset = "0x2746738", VA = "0x7BBCF46738", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170011DF RID: 4575
			// (get) Token: 0x0600F780 RID: 63360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011DF")]
			private object Current
			{
				[Token(Token = "0x600F780")]
				[Address(RVA = "0x27467A0", Offset = "0x27467A0", VA = "0x7BBCF467A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F781 RID: 63361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F781")]
			[Address(RVA = "0x27467A8", Offset = "0x27467A8", VA = "0x7BBCF467A8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600F782 RID: 63362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F782")]
			[Address(RVA = "0x2746858", Offset = "0x2746858", VA = "0x7BBCF46858", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04011B4E RID: 72526
			[Token(Token = "0x4011B4E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04011B4F RID: 72527
			[Token(Token = "0x4011B4F")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x04011B50 RID: 72528
			[Token(Token = "0x4011B50")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04011B51 RID: 72529
			[Token(Token = "0x4011B51")]
			[FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			// Token: 0x04011B52 RID: 72530
			[Token(Token = "0x4011B52")]
			[FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			// Token: 0x04011B53 RID: 72531
			[Token(Token = "0x4011B53")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;
		}
	}
}
