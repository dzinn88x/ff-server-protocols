using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001028 RID: 4136
	[Token(Token = "0x2001028")]
	public class UIInnerView
	{
		// Token: 0x06003EAE RID: 16046 RVA: 0x00013758 File Offset: 0x00011958
		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x202E040", Offset = "0x202E040", VA = "0x7BBC82E040")]
		public bool Inited()
		{
			return default(bool);
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x202E048", Offset = "0x202E048", VA = "0x7BBC82E048", Slot = "4")]
		public virtual void BindVars(GameObject ui)
		{
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB0")]
		public T Clone<T>() where T : UIInnerView, new()
		{
			return null;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB1")]
		protected void Bind<T>(out T feild, string name) where T : UnityEngine.Object
		{
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x202E0C8", Offset = "0x202E0C8", VA = "0x7BBC82E0C8")]
		public UIInnerView()
		{
		}

		// Token: 0x04004ED9 RID: 20185
		[Token(Token = "0x4004ED9")]
		[FieldOffset(Offset = "0x10")]
		private GameObject ui;

		// Token: 0x04004EDA RID: 20186
		[Token(Token = "0x4004EDA")]
		[FieldOffset(Offset = "0x18")]
		private UIItemVariable[] itemVars;

		// Token: 0x04004EDB RID: 20187
		[Token(Token = "0x4004EDB")]
		[FieldOffset(Offset = "0x20")]
		private bool inited;
	}
}
