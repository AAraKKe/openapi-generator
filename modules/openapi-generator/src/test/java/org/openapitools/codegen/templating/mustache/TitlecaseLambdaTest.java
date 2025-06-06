package org.openapitools.codegen.templating.mustache;

import org.testng.annotations.Test;

import java.util.Map;

public class TitlecaseLambdaTest extends LambdaTest {

    @Test
    public void titlecaseTest() {
        // Given
        Map<String, Object> ctx = context("titlecase", new TitlecaseLambda());

        // When & Then
        test("Once Upon A Time", "{{#titlecase}}once upon a time{{/titlecase}}", ctx);
    }

    @Test
    public void titlecaseSingleLetterTest() {
        // Given
        Map<String, Object> ctx = context("titlecase", new TitlecaseLambda());

        // When & Then
        test("O", "{{#titlecase}}o{{/titlecase}}", ctx);
    }

    @Test
    public void titlecaseEmptyStringTest() {
        // Given
        Map<String, Object> ctx = context("titlecase", new TitlecaseLambda());

        // When & Then
        test("", "{{#titlecase}}{{/titlecase}}", ctx);
    }

    @Test
    public void titlecaseWithDelimiterTest() {
        // Given
        Map<String, Object> ctx = context("titlecase", new TitlecaseLambda("-"));

        // When & Then
        test("Once-Upon-A-Time", "{{#titlecase}}once-upon-a-time{{/titlecase}}", ctx);
    }


}
