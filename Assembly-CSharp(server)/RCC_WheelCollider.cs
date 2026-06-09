using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000177 RID: 375
[Token(Token = "0x2000177")]
public class RCC_WheelCollider : MonoBehaviour, WheelColliderInterface
{
	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000077")]
	public WheelCollider wheelCollider
	{
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x23D413C", Offset = "0x23D413C", VA = "0x7BBCBD413C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x23D60C4", Offset = "0x23D60C4", VA = "0x7BBCBD60C4")]
		set
		{
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000779 RID: 1913 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x17000078")]
	public bool IsGrounded
	{
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x23CEF0C", Offset = "0x23CEF0C", VA = "0x7BBCBCEF0C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600077B RID: 1915 RVA: 0x00003630 File Offset: 0x00001830
	// (set) Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000079")]
	public float motorTorque
	{
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x23D618C", Offset = "0x23D618C", VA = "0x7BBCBD618C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x23D60CC", Offset = "0x23D60CC", VA = "0x7BBCBD60CC")]
		set
		{
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600077D RID: 1917 RVA: 0x00003648 File Offset: 0x00001848
	// (set) Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700007A")]
	public float brakeTorque
	{
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x23D62FC", Offset = "0x23D62FC", VA = "0x7BBCBD62FC")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x23D623C", Offset = "0x23D623C", VA = "0x7BBCBD623C")]
		set
		{
		}
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x23D63AC", Offset = "0x23D63AC", VA = "0x7BBCBD63AC")]
	private void Awake()
	{
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077F")]
	[Address(RVA = "0x23D6798", Offset = "0x23D6798", VA = "0x7BBCBD6798")]
	private void Start()
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000780")]
	[Address(RVA = "0x23D6820", Offset = "0x23D6820", VA = "0x7BBCBD6820")]
	private void Update()
	{
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000781")]
	[Address(RVA = "0x23D74A0", Offset = "0x23D74A0", VA = "0x7BBCBD74A0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000782")]
	[Address(RVA = "0x23D74EC", Offset = "0x23D74EC", VA = "0x7BBCBD74EC")]
	public void UpdateWheelCollider()
	{
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x6000783")]
	[Address(RVA = "0x23D66FC", Offset = "0x23D66FC", VA = "0x7BBCBD66FC")]
	private WheelFrictionCurve SetFrictionCurves(WheelFrictionCurve curve, float extremumSlip, float extremumValue, float asymptoteSlip, float asymptoteValue)
	{
		return default(WheelFrictionCurve);
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000784")]
	[Address(RVA = "0x23D6B2C", Offset = "0x23D6B2C", VA = "0x7BBCBD6B2C")]
	public void WheelAlign()
	{
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000785")]
	[Address(RVA = "0x23D72A0", Offset = "0x23D72A0", VA = "0x7BBCBD72A0")]
	public void WheelCamber()
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x23D7798", Offset = "0x23D7798", VA = "0x7BBCBD7798")]
	private void Frictions(bool contacted, float forwardSlip)
	{
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000787")]
	[Address(RVA = "0x23D78EC", Offset = "0x23D78EC", VA = "0x7BBCBD78EC")]
	private void Drift(float forwardSlip)
	{
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x23D7D1C", Offset = "0x23D7D1C", VA = "0x7BBCBD7D1C")]
	private bool isSkidding()
	{
		return default(bool);
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000789")]
	[Address(RVA = "0x23CF578", Offset = "0x23CF578", VA = "0x7BBCBCF578")]
	public void EnableWheelCollider(bool e)
	{
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x23D7DF0", Offset = "0x23D7DF0", VA = "0x7BBCBD7DF0", Slot = "4")]
	public void AttachWheelModel(Transform model)
	{
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078B")]
	[Address(RVA = "0x23D7F58", Offset = "0x23D7F58", VA = "0x7BBCBD7F58")]
	public RCC_WheelCollider()
	{
	}

	// Token: 0x04000775 RID: 1909
	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x18")]
	public RCC_CarControllerV3 carController;

	// Token: 0x04000776 RID: 1910
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x28")]
	private WheelCollider _wheelCollider;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x30")]
	private List<RCC_WheelCollider> allWheelColliders;

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x38")]
	public Transform wheelModel;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x40")]
	private float wheelRotation;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x44")]
	private float camber;

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x48")]
	internal float steerAngle;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x4C")]
	internal bool isGrounded;

	// Token: 0x0400077E RID: 1918
	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x50")]
	internal float totalSlip;

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x54")]
	internal float rpm;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x58")]
	internal float wheelRPMToSpeed;

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x5C")]
	private float wheelSlipAmountSideways;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x60")]
	private float wheelSlipAmountForward;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x64")]
	private float orgSidewaysStiffness;

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x68")]
	private float orgForwardStiffness;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0x6C")]
	public WheelFrictionCurve forwardFrictionCurve;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x4000786")]
	[FieldOffset(Offset = "0x80")]
	public WheelFrictionCurve sidewaysFrictionCurve;

	// Token: 0x04000787 RID: 1927
	[Token(Token = "0x4000787")]
	[FieldOffset(Offset = "0x94")]
	internal float tractionHelpedSidewaysStiffness;

	// Token: 0x04000788 RID: 1928
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x98")]
	private float minForwardStiffness;

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x9C")]
	private float maxForwardStiffness;

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0xA0")]
	private float minSidewaysStiffness;

	// Token: 0x0400078B RID: 1931
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0xA4")]
	private float maxSidewaysStiffness;

	// Token: 0x0400078C RID: 1932
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0xA8")]
	public float ForwardSlip;

	// Token: 0x0400078D RID: 1933
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0xAC")]
	public LayerMask ColliderMask;

	// Token: 0x0400078E RID: 1934
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0xB0")]
	internal bool disableModelTransUpdate;

	// Token: 0x0400078F RID: 1935
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0xB4")]
	private float m_ScaleY;
}
