using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000238 RID: 568
[Token(Token = "0x2000238")]
[ExecuteInEditMode]
public class UIRelocateToLabel : MonoBehaviour
{
	// Token: 0x06000B57 RID: 2903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x1FCB088", Offset = "0x1FCB088", VA = "0x7BBC7CB088")]
	private void Start()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x1FCB3BC", Offset = "0x1FCB3BC", VA = "0x7BBC7CB3BC")]
	private void Update()
	{
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x1FCB0F8", Offset = "0x1FCB0F8", VA = "0x7BBC7CB0F8")]
	private void UpdatePosition()
	{
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x1FCB450", Offset = "0x1FCB450", VA = "0x7BBC7CB450")]
	public UIRelocateToLabel()
	{
	}

	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIRelocateToLabel.RelocateUpdate UpdateMode;

	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private UIRelocateToLabel.RelocatePosition LocatePosition;

	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UILabel toLabel;

	// Token: 0x04000A52 RID: 2642
	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget target;

	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x30")]
	private string lastText;

	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	public enum RelocateUpdate
	{
		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		AtStart,
		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		InUpdate
	}

	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public enum RelocatePosition
	{
		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		ToLeft,
		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		ToRight
	}
}
