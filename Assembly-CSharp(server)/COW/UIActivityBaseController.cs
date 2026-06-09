using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013E1 RID: 5089
	[Token(Token = "0x20013E1")]
	public abstract class UIActivityBaseController : UIBaseController
	{
		// Token: 0x06005383 RID: 21379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005383")]
		[Address(RVA = "0x1A45918", Offset = "0x1A45918", VA = "0x7BBC245918", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005384")]
		[Address(RVA = "0x1A45C3C", Offset = "0x1A45C3C", VA = "0x7BBC245C3C", Slot = "28")]
		public virtual void SetData(object data)
		{
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005385")]
		[Address(RVA = "0x1A45C40", Offset = "0x1A45C40", VA = "0x7BBC245C40", Slot = "29")]
		public virtual void SelectItem(uint id)
		{
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005386")]
		[Address(RVA = "0x1A45C44", Offset = "0x1A45C44", VA = "0x7BBC245C44", Slot = "30")]
		public virtual void OnPanelDepthChanged()
		{
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005387")]
		[Address(RVA = "0x1A45C48", Offset = "0x1A45C48", VA = "0x7BBC245C48", Slot = "31")]
		public virtual void Reload()
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005388")]
		[Address(RVA = "0x1A459C0", Offset = "0x1A459C0", VA = "0x7BBC2459C0")]
		protected void FixPanelDepth(GameObject target, int baseDepth)
		{
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x1A45600", Offset = "0x1A45600", VA = "0x7BBC245600")]
		protected UIActivityBaseController()
		{
		}

		// Token: 0x020013E2 RID: 5090
		[Token(Token = "0x20013E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC110", Offset = "0x10EC110")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600538B RID: 21387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600538B")]
			[Address(RVA = "0x1A45CB0", Offset = "0x1A45CB0", VA = "0x7BBC245CB0")]
			public <>c()
			{
			}

			// Token: 0x0600538C RID: 21388 RVA: 0x00018F18 File Offset: 0x00017118
			[Token(Token = "0x600538C")]
			[Address(RVA = "0x1A45CB8", Offset = "0x1A45CB8", VA = "0x7BBC245CB8")]
			internal int <FixPanelDepth>b__5_0(UIPanel e)
			{
				return 0;
			}

			// Token: 0x04007938 RID: 31032
			[Token(Token = "0x4007938")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIActivityBaseController.<>c <>9;

			// Token: 0x04007939 RID: 31033
			[Token(Token = "0x4007939")]
			[FieldOffset(Offset = "0x8")]
			public static Func<UIPanel, int> <>9__5_0;
		}
	}
}
