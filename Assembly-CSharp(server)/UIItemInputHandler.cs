using System;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

// Token: 0x020000D6 RID: 214
[Token(Token = "0x20000D6")]
public class UIItemInputHandler : MonoBehaviour
{
	// Token: 0x060003A5 RID: 933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1CAA6FC", Offset = "0x1CAA6FC", VA = "0x7BBC4AA6FC")]
	private void Start()
	{
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x1CAA9B0", Offset = "0x1CAA9B0", VA = "0x7BBC4AA9B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x1CAAC58", Offset = "0x1CAAC58", VA = "0x7BBC4AAC58")]
	public void SetRotateType(UIItemRotateType type)
	{
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x1CAAC60", Offset = "0x1CAAC60", VA = "0x7BBC4AAC60")]
	public void SetRefencePoint(Vector3 point)
	{
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x1CAAC6C", Offset = "0x1CAAC6C", VA = "0x7BBC4AAC6C")]
	public void SetLastTouchPos(params object[] data)
	{
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x1CAAC80", Offset = "0x1CAAC80", VA = "0x7BBC4AAC80")]
	private void FingerSet(LeanFinger finger)
	{
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x1CAB138", Offset = "0x1CAB138", VA = "0x7BBC4AB138")]
	private void FingerDown(LeanFinger finger)
	{
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x1CAB18C", Offset = "0x1CAB18C", VA = "0x7BBC4AB18C")]
	private void Update()
	{
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x1CAAD80", Offset = "0x1CAAD80", VA = "0x7BBC4AAD80")]
	public bool IsTargetArea(Vector2 screenPosition)
	{
		return default(bool);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x1CAAEB8", Offset = "0x1CAAEB8", VA = "0x7BBC4AAEB8")]
	private void RotateItem(float angle)
	{
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x1CAB048", Offset = "0x1CAB048", VA = "0x7BBC4AB048")]
	private void RotatePointItem(Vector3 point, float angle)
	{
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x1CAB190", Offset = "0x1CAB190", VA = "0x7BBC4AB190")]
	public void EnableInput(bool v)
	{
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1CAB19C", Offset = "0x1CAB19C", VA = "0x7BBC4AB19C")]
	public void ResetPetInput()
	{
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x1CAB298", Offset = "0x1CAB298", VA = "0x7BBC4AB298")]
	public bool CheckOnUIClick()
	{
		return default(bool);
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x1CAB3C0", Offset = "0x1CAB3C0", VA = "0x7BBC4AB3C0")]
	public UIItemInputHandler()
	{
	}

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x18")]
	public float PanMovementSensitivity;

	// Token: 0x0400036C RID: 876
	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x1C")]
	public float RotateSensitivity;

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x20")]
	private float CurrentPanAngle;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 lastTouchPos;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 tempLastTouchPos;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x34")]
	public bool InputEnable;

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x4000371")]
	private const string TargetAreaName = "ItemRotateTouchArea";

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x38")]
	private UIItemRotateType m_CurrentRotateType;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 m_RefencePoint;

	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	private enum MouseButton
	{
		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		Left,
		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		Right,
		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		Middle,
		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		None
	}
}
